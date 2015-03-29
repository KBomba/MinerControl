using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MinerControl.History
{
    public partial class HistoryChart : UserControl
    {
        private bool _updating;
        
        public Chart Chart
        {
            get { return chart; }
        }
        
        private Series _focussedCurrentSeries;
        private Series _focussedAverageSeries;
        public Series[] FocussedSeries
        {
            get { return new[] {_focussedCurrentSeries, _focussedAverageSeries}; }
            set
            {
                if (value.Any(s => s == null)) return;

                if (_focussedCurrentSeries != null) _focussedCurrentSeries.BorderWidth = 3;
                if (_focussedAverageSeries != null) _focussedAverageSeries.BorderWidth = 2;

                _focussedCurrentSeries = value[0];
                _focussedAverageSeries = value[1];

                _focussedCurrentSeries.BorderWidth = 5;
                _focussedAverageSeries.BorderWidth = 3;

                if (chart.Series.Remove(_focussedCurrentSeries)) 
                    chart.Series.Insert(0, _focussedCurrentSeries);

                if (chart.Series.Remove(_focussedAverageSeries)) 
                    chart.Series.Insert(1, _focussedAverageSeries);
            }
        }

        public IList<ServiceHistory> History;
        public IList<ChartHistory> ChartHistories;
        public class ChartHistory
        {
            public string Entry { get; set; }
            public Color Color { get; set; }
            public List<ServiceHistory.PriceStat> PriceHistories { get; set; }
        }

        public HistoryChart()
        {
            InitializeComponent();
            chart.GetToolTipText += Chart_GetToolTipText;
        }

        public void UpdateChart(TimeSpan timeRange = default(TimeSpan), int topRange = 0)
        {
            if(History == null || History.Count == 0) return;

            _updating = true;

            List<Series> series = new List<Series>();
            HashSet<string> disabled =
                new HashSet<string>(chart.Series.Where(serie => !serie.Enabled).Select(s => s.Name));
            ChartHistories = FilterHistory(History, timeRange, topRange);

            chart.Series.Clear();
            chart.Legends[0].CustomItems.Clear();
            // Everything goes out, let's start from scratch

            foreach (ChartHistory chartHistory in ChartHistories)
            {
                Series currentSeries = new Series(chartHistory.Entry)
                {
                    Color = chartHistory.Color,
                    ChartType = SeriesChartType.Line,
                    ChartArea = "ChartArea",
                    XValueType = ChartValueType.DateTime,
                    XValueMember = "Time",
                    YValueMembers = "CurrentPrice",
                    Legend = "Legend",
                    IsVisibleInLegend = false,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerColor = chartHistory.Color,
                    MarkerSize = 5,
                    MarkerBorderColor = Color.Black,
                    BorderWidth = 3
                };

                Series averageSeries = new Series(chartHistory.Entry + " Average")
                {
                    Color = Color.FromArgb(192, chartHistory.Color),
                    ChartType = SeriesChartType.Spline,
                    ChartArea = "ChartArea",
                    XValueType = ChartValueType.DateTime,
                    XValueMember = "Time",
                    YValueMembers = "WindowedAveragePrice",
                    Legend = "Legend",
                    IsVisibleInLegend = false,
                    BorderWidth = 2
                };

                for (int index = 0; index < chartHistory.PriceHistories.Count; index++)
                {
                    ServiceHistory.PriceStat priceStat = chartHistory.PriceHistories[index];
                    ServiceHistory.PriceStat prevStat = index > 0 
                        ? chartHistory.PriceHistories[index - 1] 
                        : null;
                    ServiceHistory.PriceStat nextStat = index < chartHistory.PriceHistories.Count - 1
                        ? chartHistory.PriceHistories[index + 1]
                        : null;

                    if (prevStat == null || nextStat == null)
                    {
                        currentSeries.Points.AddXY(priceStat.Time, priceStat.CurrentPrice);
                        currentSeries.Points.Last().ToolTip = chartHistory.Entry;
                        averageSeries.Points.AddXY(priceStat.Time, priceStat.WindowedAveragePrice);
                        averageSeries.Points.Last().ToolTip = chartHistory.Entry;
                        continue;
                    }

                    // Next lines saves a lot of points in the chart, 
                    // Makes the control more fluent and look nicer
                    if (prevStat.CurrentPrice != priceStat.CurrentPrice || 
                        nextStat.CurrentPrice != priceStat.CurrentPrice)
                    {
                        currentSeries.Points.AddXY(priceStat.Time, priceStat.CurrentPrice);
                        currentSeries.Points.Last().ToolTip = chartHistory.Entry;
                    }

                    if (prevStat.WindowedAveragePrice != priceStat.WindowedAveragePrice ||
                        nextStat.WindowedAveragePrice != priceStat.WindowedAveragePrice)
                    {
                        averageSeries.Points.AddXY(priceStat.Time, priceStat.WindowedAveragePrice);
                        averageSeries.Points.Last().ToolTip = chartHistory.Entry;
                    }

                    DataPoint newlyAdded = currentSeries.Points.Last();
                    if (priceStat.Outlier)
                    {
                        newlyAdded.MarkerStyle = MarkerStyle.Cross;
                        newlyAdded.MarkerColor = Color.Red;
                        newlyAdded.MarkerSize = 6;
                    }
                }

                series.Add(currentSeries);
                series.Add(averageSeries);

                // Re-enable focussing after re-init all series
                if (_focussedCurrentSeries != null && currentSeries.Name == _focussedCurrentSeries.Name)
                {
                    FocussedSeries = new[] { currentSeries, averageSeries };
                }
            }

            series = series.OrderByDescending(s => s.Points.Last().YValues[0]).ToList();
            foreach (Series serie in series)
            {
                if (!chart.Series.Contains(serie)) chart.Series.Add(serie);

                // Re-enabling disabled ones too
                if (disabled.Contains(serie.Name))
                {
                    serie.Enabled = false;
                }
                
                if (!serie.Name.EndsWith("Average"))
                {
                    LegendItem legend = new LegendItem
                    {
                        Name = serie.Name,
                        SeriesName = serie.Name,
                        Color = serie.Color,
                        MarkerStyle = MarkerStyle.Circle,
                        BorderWidth = 3
                    };
                    chart.Legends[0].CustomItems.Add(legend);
                }
            }

            SetLegendImageStyles();

            _updating = false;
        }

        public void SetLegendImageStyles()
        {
            // Makes sure all custom legenditems adhere to what's focussed and disabled
            foreach (LegendItem legend in chart.Legends[0].CustomItems)
            {
                if (_focussedCurrentSeries != null && legend.Name == _focussedCurrentSeries.Name)
                {
                    legend.ImageStyle = LegendImageStyle.Rectangle;
                }
                else
                {
                    legend.ImageStyle = LegendImageStyle.Line;
                }

                foreach (Series serie in chart.Series)
                {
                    if (serie.Name == legend.Name && !serie.Enabled)
                    {
                        legend.ImageStyle = LegendImageStyle.Marker;
                    }
                }
            }
        }

        private static IList<ChartHistory> FilterHistory(
            IEnumerable<ServiceHistory> history, TimeSpan timeRange, int topRange)
        {
            DateTime now = DateTime.Now;
            IList<ChartHistory> chartHistories =
                (history.SelectMany(serviceHistory => serviceHistory.PriceList,
                    (serviceHistory, prices) => new ChartHistory
                    {
                        Entry = serviceHistory.Service + " " + prices.Key.Name,
                        Color = prices.Key.Color ?? Color.Black,
                        PriceHistories = timeRange >= new TimeSpan(0, 1, 0)
                            ? prices.Value.Where(p => p.Time > now - timeRange).ToList()
                            : prices.Value
                    }).OrderByDescending(ch => ch.PriceHistories.Last().CurrentPrice)).ToList();
            // Copies the list into something the chart will easily understand, removing items out of timerange

            if (topRange > 0)
            {
                HashSet<string> topPerformers = new HashSet<string>();
                for (int i = 0; i < chartHistories[0].PriceHistories.Count; i++)
                {
                    // Looks through every timestamp for the top performers
                    List<Tuple<string, decimal>> candidates = new List<Tuple<string, decimal>>(topRange);
                    foreach (ChartHistory chartHistory in chartHistories)
                    {
                        if (i < chartHistory.PriceHistories.Count)
                        {
                            if (candidates.Count < topRange)
                            {
                                candidates.Add(new Tuple<string, decimal>(chartHistory.Entry,
                                    chartHistory.PriceHistories[i].CurrentPrice));
                            }
                            else if (chartHistory.PriceHistories[i].CurrentPrice > candidates.Last().Item2)
                            {
                                candidates.Remove(candidates.Last());
                                candidates.Add(new Tuple<string, decimal>(chartHistory.Entry,
                                    chartHistory.PriceHistories[i].CurrentPrice));
                            }

                            candidates = candidates.OrderByDescending(c => c.Item2).ToList();
                        }
                    }

                    foreach (Tuple<string, decimal> candidate in candidates)
                    {
                        topPerformers.Add(candidate.Item1);
                    }
                }

                chartHistories =
                    (from chartHistory in chartHistories
                     from topPerformer in topPerformers
                     where chartHistory.Entry == topPerformer
                     select chartHistory).ToList();
            }

            return chartHistories;
        }

        public void FlipLegend()
        {
            if (chart.Legends["Legend"].Docking == Docking.Right)
            {
                chart.Legends["Legend"].Docking = Docking.Top;
                chart.Legends["Legend"].Alignment = StringAlignment.Far;
                chart.Legends["Legend"].LegendStyle = LegendStyle.Row;
            }
            else if (chart.Legends["Legend"].Docking == Docking.Top)
            {
                chart.Legends["Legend"].Docking = Docking.Right;
                chart.Legends["Legend"].Alignment = StringAlignment.Near;
                chart.Legends["Legend"].LegendStyle = LegendStyle.Column;
            }
        }

        private void Chart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (_updating) return;

            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                double pixelPosition = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                DateTime dt = DateTime.FromOADate(pixelPosition);
                List<Tuple<string, ServiceHistory.PriceStat>> group = new List<Tuple<string, ServiceHistory.PriceStat>>();
                foreach (ChartHistory chartHistory in ChartHistories)
                {
                    foreach (ServiceHistory.PriceStat priceStat in chartHistory.PriceHistories)
                    {
                        if (priceStat.Time >= dt - TimeSpan.FromSeconds(30) &&
                            priceStat.Time <= dt + TimeSpan.FromSeconds(30))
                        {
                            group.Add(new Tuple<string, ServiceHistory.PriceStat>(chartHistory.Entry, priceStat));
                            break;
                        }
                    }
                }

                group = group.OrderByDescending(o => o.Item2.CurrentPrice).ToList();
                Tuple<string, ServiceHistory.PriceStat> first = group.FirstOrDefault();
                if (first != null)
                {
                    StringBuilder sb = new StringBuilder("Time: ").Append(first.Item2.Time.ToString("g"));

                    foreach (Tuple<string, ServiceHistory.PriceStat> tuple in @group)
                    {
                        sb.Append(Environment.NewLine)
                            .Append(dp.YValues[0] == (double)tuple.Item2.CurrentPrice ||
                                    dp.YValues[0] == (double)tuple.Item2.WindowedAveragePrice
                                ? "→ " : "")
                            .Append(tuple.Item1)
                            .Append(": ")
                            .Append(tuple.Item2.CurrentPrice.ToString("N6"))
                            .Append(" [")
                            .Append(tuple.Item2.WindowedAveragePrice.ToString("N6"))
                            .Append("]");
                    }

                    e.Text = sb.ToString();
                }
            }
        }

        private void chart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);
            LegendItem legend = result.Object as LegendItem;
            Series focussedSeries = null;
            if (legend != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    chart.Series[legend.SeriesName].Enabled = !chart.Series[legend.SeriesName].Enabled;
                }
                else
                {
                    focussedSeries = chart.Series[legend.SeriesName];
                }
            }
            else
            {
                DataPoint dataPoint = result.Object as DataPoint;
                if (dataPoint != null)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        chart.Series[dataPoint.ToolTip].Enabled = !chart.Series[dataPoint.ToolTip].Enabled;
                    }
                    else
                    {
                        focussedSeries = chart.Series[dataPoint.ToolTip];
                    }
                }
            }

            foreach (Series serie in chart.Series)
            {
                if (serie.Name.EndsWith("Average"))
                {
                    serie.Enabled = chart.Series[serie.Name.Replace(" Average", string.Empty).Trim()].Enabled;

                    if (focussedSeries != null && serie.Name.StartsWith(focussedSeries.Name))
                    {
                        FocussedSeries = new[] {focussedSeries, serie};
                        break;
                    }
                }
            }

            SetLegendImageStyles();
        }
    }
}
