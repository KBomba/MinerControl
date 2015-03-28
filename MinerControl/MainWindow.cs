using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using MinerControl.History;
using MinerControl.PriceEntries;
using MinerControl.Services;
using MinerControl.Utility;

namespace MinerControl
{
    public partial class MainWindow : Form
    {
        private DateTime _appStartTime = DateTime.Now;
        private readonly SlidingBuffer<string> _consoleBuffer = new SlidingBuffer<string>(200);
        private MiningEngine _engine = new MiningEngine();
        private readonly SlidingBuffer<string> _remoteBuffer = new SlidingBuffer<string>(200);
        private TotalHistoryForm _totalHistoryForm;

        public MainWindow()
        {
            _engine.WriteConsoleAction = WriteConsole;
            _engine.WriteRemoteAction = WriteRemote;

            InitializeComponent();
        }

        private bool IsMinimizedToTray
        {
            get { return _engine.TrayMode > 0 && WindowState == FormWindowState.Minimized; }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!_engine.LoadConfig())
                Close();
            if (!string.IsNullOrWhiteSpace(_engine.CurrencyCode))
                _engine.LoadExchangeRates();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            // speeds up data grid view performance.
            typeof (DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgPrices,
                new object[] {true});
            typeof (DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgServices,
                new object[] {true});

            dgServices.AutoGenerateColumns = false;
            dgServices.DataSource = new SortableBindingList<IService>(_engine.Services);

            dgPrices.AutoGenerateColumns = false;
            dgPrices.DataSource = new SortableBindingList<PriceEntryBase>(_engine.PriceEntries);

            if (!_engine.DoDonationMinging)
            {
                textDonationStart.Enabled = false;
                textDonationEnd.Enabled = false;
            }

            lblCurrencySymbol.Text = string.Empty; // Avoid flashing template value when starting

            if (!_engine.RemoteReceive)
                tabPage.TabPages.Remove(tabRemote);

            UpdateButtons();
            RunCycle();
            UpdateGrid(true);

            if (Program.MinimizeOnStart)
                MinimizeWindow();

            tmrPriceCheck.Enabled = true;
            if (!string.IsNullOrWhiteSpace(_engine.CurrencyCode))
                tmrExchangeUpdate.Enabled = true;
            if (Program.HasAutoStart)
            {
                _engine.MiningMode = MiningModeEnum.Automatic;
                UpdateButtons();
                RunBestAlgo();
            }

            HistoryChart historyChart = tabHistory.Controls["historyChart"] as HistoryChart;
            if (historyChart != null)
            {
                historyChart.History = _engine.PriceHistories;
                historyChart.FlipLegend();
                historyChart.UpdateChart(_engine.StatWindow);
                historyChart.Chart.DoubleClick += ChartOnDoubleClick;
            }
        }

        private void ChartOnDoubleClick(object sender, EventArgs eventArgs)
        {
            if (_totalHistoryForm != null)
            {
                _totalHistoryForm.Focus();
            }
            else
            {

                _totalHistoryForm = new TotalHistoryForm(_engine.PriceHistories);
                _totalHistoryForm.FormClosing += _totalHistoryForm_FormClosing;
                _totalHistoryForm.Show();
            }
        }

        void _totalHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _totalHistoryForm = null;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _engine.Cleanup();
        }

        private void RunCycle()
        {
            _engine.CheckPrices();
        }

        private void RunBestAlgo()
        {
            if (!_engine.HasPrices || (Program.HasAutoStart && (DateTime.Now - _appStartTime).TotalSeconds < 3)) return;

            int? oldCurrent = _engine.CurrentRunning;
            int? oldNext = _engine.NextRun;
            _engine.RunBestAlgo(IsMinimizedToTray);
            if (_engine.CurrentRunning != oldCurrent || _engine.NextRun != oldNext)
                UpdateGrid();
        }

        private void UpdateButtons()
        {
            btnStart.Enabled = _engine.MiningMode == MiningModeEnum.Stopped;
            btnStop.Enabled = _engine.MiningMode != MiningModeEnum.Stopped;
            dgPrices.Columns[dgPrices.Columns.Count - 2].Visible = _engine.MiningMode != MiningModeEnum.Stopped;
            // Status column
            dgPrices.Columns[dgPrices.Columns.Count - 1].Visible = _engine.MiningMode == MiningModeEnum.Stopped;
            // Action column
        }

        private void UpdateGrid(bool forceReorder = false)
        {
            lock (_engine)
            {
                // mode 2 == sort always, mode 1 == sort when running, mode 0 == sort never
                if (_engine.GridSortMode == 2 ||
                    (_engine.GridSortMode == 1 && (forceReorder || _engine.MiningMode == MiningModeEnum.Automatic)))
                {
                    string column = _engine.MineByAverage ? "NetAverage" : "NetEarn";
                    dgPrices.Sort(dgPrices.Columns[column], ListSortDirection.Descending);
                }
            }
        }

        private void linkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://blockchain.info/address/1F9fsG5xLLn6uc7cdbgV1LTFWjWQSqXohX");
        }

        private void UpdateTimes()
        {
            textRunningTotal.Text = _engine.TotalTime.FormatTime();
            textTimeCurrent.Text = _engine.MiningTime.FormatTime();
            textTimeSwitch.Text = _engine.NextRunTime.FormatTime();
            textTimeRestart.Text = _engine.RestartTime.FormatTime();
            textDonationStart.Text = _engine.TimeUntilDonation.FormatTime();
            textDonationEnd.Text = _engine.TimeDuringDonation.FormatTime();
            textCurrencyExchange.Text = _engine.Exchange.ToString("N2");
            lblCurrencySymbol.Text = _engine.CurrencySymbol;
            if (_engine.Services != null)
            {
                decimal balance = _engine.Services.Select(o => o.Currency).Sum();
                textCurrencyBalance.Text = balance.ToString("N4");
            }
        }

        private string ActiveTime(PriceEntryBase priceEntry)
        {
            TimeSpan time = priceEntry.TimeMining;
            if (_engine.CurrentRunning == priceEntry.Id && _engine.StartMining.HasValue)
                time += (DateTime.Now - _engine.StartMining.Value);
            return time.FormatTime();
        }

        private void WriteConsole(string text)
        {
            Invoke(new MethodInvoker(
                delegate
                {
                    _consoleBuffer.Add(text);

                    textConsole.Lines = _consoleBuffer.ToArray();
                    textConsole.Focus();
                    textConsole.SelectionStart = textConsole.Text.Length;
                    textConsole.SelectionLength = 0;
                    textConsole.ScrollToCaret();
                    textConsole.Refresh();
                }));
        }

        private void WriteRemote(IPAddress source, string text)
        {
            Invoke(new MethodInvoker(
                delegate
                {
                    _remoteBuffer.Add(string.Format("[{0}] {1}", source, text));

                    textRemote.Lines = _remoteBuffer.ToArray();
                    textRemote.Focus();
                    textRemote.SelectionStart = textRemote.Text.Length;
                    textRemote.SelectionLength = 0;
                    textRemote.ScrollToCaret();
                    textRemote.Refresh();
                }
                ));
        }

        #region Show/hide window

        private void MinimizeWindow()
        {
            if (_engine.TrayMode == 0)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                HideWindow();
            }
        }

        private void HideWindow()
        {
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(500);
            Hide();

            _engine.HideMinerWindow();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;

            _engine.MinimizeMinerWindow();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (_engine.TrayMode > 0 && WindowState == FormWindowState.Minimized)
            {
                HideWindow();
            }
        }

        #endregion

        #region Buttons

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_engine.MiningMode != MiningModeEnum.Stopped) return;
            _engine.MiningMode = MiningModeEnum.Automatic;

            UpdateButtons();
            RunBestAlgo();
            UpdateGrid();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_engine.MiningMode == MiningModeEnum.Stopped) return;
            _engine.MiningMode = MiningModeEnum.Stopped;

            UpdateButtons();
            _engine.RequestStop();
            UpdateGrid();
        }

        private void btnReloadConfig_Click(object sender, EventArgs e)
        {
            MiningModeEnum originalMode = _engine.MiningMode;
            ServiceEnum service = ServiceEnum.Manual;
            string algo = string.Empty;
            if (_engine.CurrentPriceEntry != null)
            {
                service = _engine.CurrentPriceEntry.ServiceEntry.ServiceEnum;
                algo = _engine.CurrentPriceEntry.AlgoName;
            }
            
            _engine.Cleanup();
            _engine = new MiningEngine
            {
                WriteConsoleAction = WriteConsole, 
                WriteRemoteAction = WriteRemote
            };
            _appStartTime = DateTime.Now;

            if (!_engine.LoadConfig())
                MessageBox.Show("Something went wrong with reloading your configuration file. Check for errors.",
                    "Error loading conf", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dgServices.DataSource = new SortableBindingList<IService>(_engine.Services);
            dgPrices.DataSource = new SortableBindingList<PriceEntryBase>(_engine.PriceEntries);

            _engine.MiningMode = originalMode;
            
            _engine.LoadExchangeRates();
            RunCycle();
            UpdateButtons();
            UpdateGrid();

            HistoryChart historyChart = tabHistory.Controls["historyChart"] as HistoryChart;
            if (historyChart != null) historyChart.UpdateChart();

            if (originalMode == MiningModeEnum.Manual)
            {
                _engine.RequestStart(service, algo, IsMinimizedToTray);
            }
        }

        private void dgPrices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_engine.MiningMode != MiningModeEnum.Stopped) return;

            DataGridView senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                IList<PriceEntryBase> data = senderGrid.DataSource as IList<PriceEntryBase>;
                PriceEntryBase entry = data[e.RowIndex];

                _engine.MiningMode = MiningModeEnum.Manual;
                UpdateButtons();
                _engine.RequestStart(entry.Id, IsMinimizedToTray);
                UpdateGrid();
            }
        }

        private void dgPrices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView senderGrid = (DataGridView) sender;

            if (e.RowIndex >= 0)
            {
                IList<PriceEntryBase> data = senderGrid.DataSource as IList<PriceEntryBase>;
                PriceEntryBase entry = data[e.RowIndex];

                _engine.SwitchBanStatus(entry.ServicePrint);
                UpdateGrid();
            }
        }

        #endregion

        #region Timer events

        private void tmrPriceCheck_Tick(object sender, EventArgs e)
        {
            RunCycle();
            UpdateGrid();
        }

        private void tmrExchangeUpdate_Tick(object sender, EventArgs e)
        {
            _engine.LoadExchangeRates();
        }

        private void tmrTimeUpdate_Tick(object sender, EventArgs e)
        {
            if (_engine.ExitTime.HasValue && DateTime.Now >= _engine.ExitTime) Application.Exit();

            UpdateTimes();

            if (_engine.PricesUpdated)
            {
                UpdateGrid();

                HistoryChart historyChart = tabHistory.Controls["historyChart"] as HistoryChart;
                if (historyChart != null) historyChart.UpdateChart(TimeSpan.FromMinutes(20), 3);
                if (_totalHistoryForm != null) _totalHistoryForm.UpdateChart();

                _engine.PricesUpdated = false;
            }

            MiningModeEnum[] autoModes = {MiningModeEnum.Automatic, MiningModeEnum.Donation};
            if (!autoModes.Contains(_engine.MiningMode)) return;

            RunBestAlgo();
        }

        #endregion
    }
}