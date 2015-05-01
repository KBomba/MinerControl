namespace MinerControl.History
{
    partial class HistoryChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.cmsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea4.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 50;
            chartArea4.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea4.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea4.CursorX.AutoScroll = false;
            chartArea4.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorY.AutoScroll = false;
            chartArea4.CursorY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.InterlacedRows = true;
            legend4.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend4.Name = "Legend";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series4.BackSecondaryColor = System.Drawing.Color.Black;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.BorderWidth = 10;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerBorderWidth = 10;
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Series1";
            series4.ShadowColor = System.Drawing.Color.Black;
            series4.ShadowOffset = 10;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(903, 367);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_MouseClick);
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.cmsRightClick.Name = "cmsRightClick";
            this.cmsRightClick.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsRightClick.Size = new System.Drawing.Size(153, 48);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // HistoryChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "HistoryChart";
            this.Size = new System.Drawing.Size(903, 367);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.cmsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}
