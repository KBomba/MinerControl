namespace MinerControl.History
{
    partial class TotalHistoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalHistoryForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgPrices = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetEarn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyChart = new MinerControl.History.HistoryChart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.historyChart);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgPrices);
            this.splitContainer.Size = new System.Drawing.Size(947, 603);
            this.splitContainer.SplitterDistance = 753;
            this.splitContainer.TabIndex = 0;
            // 
            // dgPrices
            // 
            this.dgPrices.AllowUserToAddRows = false;
            this.dgPrices.AllowUserToDeleteRows = false;
            this.dgPrices.AllowUserToResizeColumns = false;
            this.dgPrices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.NetEarn,
            this.NetAverage});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPrices.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPrices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPrices.Location = new System.Drawing.Point(0, 0);
            this.dgPrices.Name = "dgPrices";
            this.dgPrices.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPrices.RowHeadersVisible = false;
            this.dgPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrices.ShowCellErrors = false;
            this.dgPrices.ShowCellToolTips = false;
            this.dgPrices.ShowEditingIcon = false;
            this.dgPrices.ShowRowErrors = false;
            this.dgPrices.Size = new System.Drawing.Size(190, 603);
            this.dgPrices.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // NetEarn
            // 
            this.NetEarn.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N6";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.NetEarn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NetEarn.HeaderText = "Net";
            this.NetEarn.Name = "NetEarn";
            this.NetEarn.ReadOnly = true;
            this.NetEarn.ToolTipText = "BTC/day";
            this.NetEarn.Width = 60;
            // 
            // NetAverage
            // 
            this.NetAverage.DataPropertyName = "WindowedAveragePrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.NetAverage.DefaultCellStyle = dataGridViewCellStyle4;
            this.NetAverage.HeaderText = "Average";
            this.NetAverage.Name = "NetAverage";
            this.NetAverage.ReadOnly = true;
            this.NetAverage.ToolTipText = "BTC/day";
            this.NetAverage.Width = 60;
            // 
            // historyChart
            // 
            this.historyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyChart.FocussedSeries = new System.Windows.Forms.DataVisualization.Charting.Series[] {
        null,
        null};
            this.historyChart.Location = new System.Drawing.Point(0, 0);
            this.historyChart.Name = "historyChart";
            this.historyChart.Size = new System.Drawing.Size(753, 603);
            this.historyChart.TabIndex = 0;
            // 
            // TotalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 603);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalHistoryForm";
            this.Text = "Miner Control ~ History Overview";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgPrices;
        private HistoryChart historyChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetEarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAverage;
    }
}