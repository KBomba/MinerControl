using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MinerControl.History
{
    public partial class TotalHistoryForm : Form
    {
        public HistoryChart HistoryChart
        {
            get { return historyChart; }
        }

        public TotalHistoryForm(IList<ServiceHistory> history)
        {
            InitializeComponent();

            historyChart.History = history;
            historyChart.UpdateChart();
            historyChart.Chart.MouseClick += HistoryChartOnMouseClick;

            dgPrices.AutoGenerateColumns = false;
            UpdateDataGrid();
        }

        private void HistoryChartOnMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            UpdateDataGrid(true);
        }

        public void UpdateChart()
        {
            historyChart.UpdateChart();
            UpdateDataGrid(true);
        }

        private void UpdateDataGrid(bool limit = false)
        {
            if (historyChart.ChartHistories != null && historyChart.ChartHistories.Count > 0 
                && (!limit || historyChart.ChartHistories.Count <= 1000))
            {
                dgPrices.DataSource = null;

                if (historyChart.FocussedSeries == null || historyChart.FocussedSeries[0] == null)
                {
                    HistoryChart.ChartHistory first = historyChart.ChartHistories.First();
                    Series[] focussedSeries = new Series[2];

                    foreach (Series series in historyChart.Chart.Series)
                    {
                        if (series.Name == first.Entry)
                        {
                            focussedSeries[0] = series;
                        }
                        else if (series.Name.Remove("Average") == first.Entry)
                        {
                            focussedSeries[1] = series;
                        }
                    }

                    historyChart.FocussedSeries = focussedSeries;
                    dgPrices.DataSource = first.PriceHistories;
                }
                else
                {
                    foreach (HistoryChart.ChartHistory history in historyChart.ChartHistories)
                    {
                        if (history.Entry == historyChart.FocussedSeries[0].Name)
                        {
                            dgPrices.DataSource = history.PriceHistories;
                            break;
                        }
                    }
                }

                historyChart.SetLegendImageStyles();
            }
        }
    }
}
