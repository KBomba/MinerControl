﻿namespace MinerControl
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrPriceCheck = new System.Windows.Forms.Timer(this.components);
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbTimes = new System.Windows.Forms.GroupBox();
            this.textRunningTotal = new System.Windows.Forms.TextBox();
            this.textTimeRestart = new System.Windows.Forms.TextBox();
            this.textTimeSwitch = new System.Windows.Forms.TextBox();
            this.textTimeCurrent = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTimeCurrent = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.dgPrices = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hashrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetEarn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeMining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhStart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgServices = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceRunning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDonation = new System.Windows.Forms.GroupBox();
            this.textDonationStart = new System.Windows.Forms.TextBox();
            this.textDonationEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbActions.SuspendLayout();
            this.gbTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            this.gbDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(41, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Auto";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(41, 20);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrPriceCheck
            // 
            this.tmrPriceCheck.Interval = 60000;
            this.tmrPriceCheck.Tick += new System.EventHandler(this.tmrPriceCheck_Tick);
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnStop);
            this.gbActions.Controls.Add(this.btnStart);
            this.gbActions.Location = new System.Drawing.Point(16, 31);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(62, 96);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // linkDonate
            // 
            this.linkDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDonate.AutoSize = true;
            this.linkDonate.LinkArea = new System.Windows.Forms.LinkArea(45, 34);
            this.linkDonate.Location = new System.Drawing.Point(16, 577);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(454, 17);
            this.linkDonate.TabIndex = 9;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "If you like this, please donate some mBTC to 1PMj3nrVq5CH4TXdJSnHHLPdvcXinjG72y.";
            this.linkDonate.UseCompatibleTextRendering = true;
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Miner Control v1.2.0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Miner Control is still running\r\nDouble-click to restore";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Miner Control";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // gbTimes
            // 
            this.gbTimes.Controls.Add(this.textRunningTotal);
            this.gbTimes.Controls.Add(this.textTimeRestart);
            this.gbTimes.Controls.Add(this.textTimeSwitch);
            this.gbTimes.Controls.Add(this.textTimeCurrent);
            this.gbTimes.Controls.Add(this.label20);
            this.gbTimes.Controls.Add(this.label19);
            this.gbTimes.Controls.Add(this.lblTimeCurrent);
            this.gbTimes.Controls.Add(this.label18);
            this.gbTimes.Location = new System.Drawing.Point(84, 31);
            this.gbTimes.Name = "gbTimes";
            this.gbTimes.Size = new System.Drawing.Size(163, 96);
            this.gbTimes.TabIndex = 11;
            this.gbTimes.TabStop = false;
            this.gbTimes.Text = "Times";
            // 
            // textRunningTotal
            // 
            this.textRunningTotal.Location = new System.Drawing.Point(9, 32);
            this.textRunningTotal.Name = "textRunningTotal";
            this.textRunningTotal.ReadOnly = true;
            this.textRunningTotal.Size = new System.Drawing.Size(63, 20);
            this.textRunningTotal.TabIndex = 1;
            this.textRunningTotal.TabStop = false;
            this.textRunningTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTimeRestart
            // 
            this.textTimeRestart.Location = new System.Drawing.Point(87, 70);
            this.textTimeRestart.Name = "textTimeRestart";
            this.textTimeRestart.ReadOnly = true;
            this.textTimeRestart.Size = new System.Drawing.Size(63, 20);
            this.textTimeRestart.TabIndex = 1;
            this.textTimeRestart.TabStop = false;
            this.textTimeRestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTimeSwitch
            // 
            this.textTimeSwitch.Location = new System.Drawing.Point(9, 70);
            this.textTimeSwitch.Name = "textTimeSwitch";
            this.textTimeSwitch.ReadOnly = true;
            this.textTimeSwitch.Size = new System.Drawing.Size(63, 20);
            this.textTimeSwitch.TabIndex = 1;
            this.textTimeSwitch.TabStop = false;
            this.textTimeSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTimeCurrent
            // 
            this.textTimeCurrent.Location = new System.Drawing.Point(87, 32);
            this.textTimeCurrent.Name = "textTimeCurrent";
            this.textTimeCurrent.ReadOnly = true;
            this.textTimeCurrent.Size = new System.Drawing.Size(63, 20);
            this.textTimeCurrent.TabIndex = 1;
            this.textTimeCurrent.TabStop = false;
            this.textTimeCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(84, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Restart";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Switch";
            // 
            // lblTimeCurrent
            // 
            this.lblTimeCurrent.AutoSize = true;
            this.lblTimeCurrent.Location = new System.Drawing.Point(84, 16);
            this.lblTimeCurrent.Name = "lblTimeCurrent";
            this.lblTimeCurrent.Size = new System.Drawing.Size(41, 13);
            this.lblTimeCurrent.TabIndex = 0;
            this.lblTimeCurrent.Text = "Current";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Running";
            // 
            // tmrTimeUpdate
            // 
            this.tmrTimeUpdate.Enabled = true;
            this.tmrTimeUpdate.Interval = 1000;
            this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
            // 
            // dgPrices
            // 
            this.dgPrices.AllowUserToAddRows = false;
            this.dgPrices.AllowUserToDeleteRows = false;
            this.dgPrices.AllowUserToResizeColumns = false;
            this.dgPrices.AllowUserToResizeRows = false;
            this.dgPrices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ServicePrint,
            this.Algo,
            this.Hashrate,
            this.Price,
            this.Earn,
            this.Fees,
            this.PowerCost,
            this.NetEarn,
            this.Balance,
            this.AcceptSpeed,
            this.RejectSpeed,
            this.TimeMining,
            this.StatusPrint,
            this.btnNhStart});
            this.dgPrices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPrices.Location = new System.Drawing.Point(12, 155);
            this.dgPrices.MultiSelect = false;
            this.dgPrices.Name = "dgPrices";
            this.dgPrices.ReadOnly = true;
            this.dgPrices.RowHeadersVisible = false;
            this.dgPrices.ShowCellErrors = false;
            this.dgPrices.ShowCellToolTips = false;
            this.dgPrices.ShowEditingIcon = false;
            this.dgPrices.ShowRowErrors = false;
            this.dgPrices.Size = new System.Drawing.Size(791, 403);
            this.dgPrices.TabIndex = 12;
            this.dgPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrices_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ServicePrint
            // 
            this.ServicePrint.DataPropertyName = "ServicePrint";
            this.ServicePrint.HeaderText = "Service";
            this.ServicePrint.Name = "ServicePrint";
            this.ServicePrint.ReadOnly = true;
            this.ServicePrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicePrint.Width = 70;
            // 
            // Algo
            // 
            this.Algo.DataPropertyName = "Name";
            this.Algo.HeaderText = "Algo";
            this.Algo.Name = "Algo";
            this.Algo.ReadOnly = true;
            this.Algo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Algo.Width = 60;
            // 
            // Hashrate
            // 
            this.Hashrate.DataPropertyName = "Hashrate";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Hashrate.DefaultCellStyle = dataGridViewCellStyle29;
            this.Hashrate.HeaderText = "Hash";
            this.Hashrate.Name = "Hashrate";
            this.Hashrate.ReadOnly = true;
            this.Hashrate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hashrate.ToolTipText = "Kh/sec";
            this.Hashrate.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "N6";
            dataGridViewCellStyle30.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle30;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.ToolTipText = "BTC/GH/day";
            this.Price.Width = 60;
            // 
            // Earn
            // 
            this.Earn.DataPropertyName = "Earn";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "N6";
            dataGridViewCellStyle31.NullValue = null;
            this.Earn.DefaultCellStyle = dataGridViewCellStyle31;
            this.Earn.HeaderText = "Earn";
            this.Earn.Name = "Earn";
            this.Earn.ReadOnly = true;
            this.Earn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Earn.ToolTipText = "BTC/day";
            this.Earn.Width = 60;
            // 
            // Fees
            // 
            this.Fees.DataPropertyName = "Fees";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N6";
            this.Fees.DefaultCellStyle = dataGridViewCellStyle32;
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            this.Fees.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fees.ToolTipText = "BTC/day";
            this.Fees.Width = 60;
            // 
            // PowerCost
            // 
            this.PowerCost.DataPropertyName = "PowerCost";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N6";
            dataGridViewCellStyle33.NullValue = null;
            this.PowerCost.DefaultCellStyle = dataGridViewCellStyle33;
            this.PowerCost.HeaderText = "Power";
            this.PowerCost.Name = "PowerCost";
            this.PowerCost.ReadOnly = true;
            this.PowerCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PowerCost.ToolTipText = "BTC/day";
            this.PowerCost.Width = 60;
            // 
            // NetEarn
            // 
            this.NetEarn.DataPropertyName = "NetEarn";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N6";
            dataGridViewCellStyle34.NullValue = null;
            this.NetEarn.DefaultCellStyle = dataGridViewCellStyle34;
            this.NetEarn.HeaderText = "Net";
            this.NetEarn.Name = "NetEarn";
            this.NetEarn.ReadOnly = true;
            this.NetEarn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NetEarn.ToolTipText = "BTC/day";
            this.NetEarn.Width = 60;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "BalancePrint";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.NullValue = null;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle35;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Balance.ToolTipText = "BTC";
            this.Balance.Width = 65;
            // 
            // AcceptSpeed
            // 
            this.AcceptSpeed.DataPropertyName = "AcceptSpeedPrint";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.NullValue = null;
            this.AcceptSpeed.DefaultCellStyle = dataGridViewCellStyle36;
            this.AcceptSpeed.HeaderText = "Accept";
            this.AcceptSpeed.Name = "AcceptSpeed";
            this.AcceptSpeed.ReadOnly = true;
            this.AcceptSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AcceptSpeed.Width = 45;
            // 
            // RejectSpeed
            // 
            this.RejectSpeed.DataPropertyName = "RejectSpeedPrint";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle37.NullValue = null;
            this.RejectSpeed.DefaultCellStyle = dataGridViewCellStyle37;
            this.RejectSpeed.HeaderText = "Reject";
            this.RejectSpeed.Name = "RejectSpeed";
            this.RejectSpeed.ReadOnly = true;
            this.RejectSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RejectSpeed.Width = 45;
            // 
            // TimeMining
            // 
            this.TimeMining.DataPropertyName = "TimeMiningPrint";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TimeMining.DefaultCellStyle = dataGridViewCellStyle38;
            this.TimeMining.HeaderText = "Running";
            this.TimeMining.Name = "TimeMining";
            this.TimeMining.ReadOnly = true;
            this.TimeMining.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeMining.Width = 70;
            // 
            // StatusPrint
            // 
            this.StatusPrint.DataPropertyName = "StatusPrint";
            this.StatusPrint.HeaderText = "Status";
            this.StatusPrint.Name = "StatusPrint";
            this.StatusPrint.ReadOnly = true;
            this.StatusPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusPrint.Width = 55;
            // 
            // btnNhStart
            // 
            this.btnNhStart.HeaderText = "Action";
            this.btnNhStart.Name = "btnNhStart";
            this.btnNhStart.ReadOnly = true;
            this.btnNhStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnNhStart.Text = "Start";
            this.btnNhStart.UseColumnTextForButtonValue = true;
            this.btnNhStart.Width = 55;
            // 
            // dgServices
            // 
            this.dgServices.AllowUserToAddRows = false;
            this.dgServices.AllowUserToDeleteRows = false;
            this.dgServices.AllowUserToResizeColumns = false;
            this.dgServices.AllowUserToResizeRows = false;
            this.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceLastUpdated,
            this.ServiceBalance,
            this.ServiceRunning});
            this.dgServices.Location = new System.Drawing.Point(514, 9);
            this.dgServices.Name = "dgServices";
            this.dgServices.ReadOnly = true;
            this.dgServices.RowHeadersVisible = false;
            this.dgServices.ShowCellErrors = false;
            this.dgServices.ShowCellToolTips = false;
            this.dgServices.ShowEditingIcon = false;
            this.dgServices.ShowRowErrors = false;
            this.dgServices.Size = new System.Drawing.Size(289, 140);
            this.dgServices.TabIndex = 13;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServicePrint";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ServiceName.DefaultCellStyle = dataGridViewCellStyle39;
            this.ServiceName.HeaderText = "Service";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceName.Width = 70;
            // 
            // ServiceLastUpdated
            // 
            this.ServiceLastUpdated.DataPropertyName = "LastUpdatedPrint";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceLastUpdated.DefaultCellStyle = dataGridViewCellStyle40;
            this.ServiceLastUpdated.HeaderText = "Updated";
            this.ServiceLastUpdated.Name = "ServiceLastUpdated";
            this.ServiceLastUpdated.ReadOnly = true;
            this.ServiceLastUpdated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceLastUpdated.Width = 65;
            // 
            // ServiceBalance
            // 
            this.ServiceBalance.DataPropertyName = "BalancePrint";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceBalance.DefaultCellStyle = dataGridViewCellStyle41;
            this.ServiceBalance.HeaderText = "Balance";
            this.ServiceBalance.Name = "ServiceBalance";
            this.ServiceBalance.ReadOnly = true;
            this.ServiceBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceBalance.Width = 65;
            // 
            // ServiceRunning
            // 
            this.ServiceRunning.DataPropertyName = "TimeMiningPrint";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceRunning.DefaultCellStyle = dataGridViewCellStyle42;
            this.ServiceRunning.HeaderText = "Running";
            this.ServiceRunning.Name = "ServiceRunning";
            this.ServiceRunning.ReadOnly = true;
            this.ServiceRunning.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceRunning.Width = 65;
            // 
            // gbDonation
            // 
            this.gbDonation.Controls.Add(this.textDonationStart);
            this.gbDonation.Controls.Add(this.textDonationEnd);
            this.gbDonation.Controls.Add(this.label1);
            this.gbDonation.Controls.Add(this.label2);
            this.gbDonation.Location = new System.Drawing.Point(254, 31);
            this.gbDonation.Name = "gbDonation";
            this.gbDonation.Size = new System.Drawing.Size(76, 96);
            this.gbDonation.TabIndex = 14;
            this.gbDonation.TabStop = false;
            this.gbDonation.Text = "Donation";
            // 
            // textDonationStart
            // 
            this.textDonationStart.Location = new System.Drawing.Point(6, 32);
            this.textDonationStart.Name = "textDonationStart";
            this.textDonationStart.ReadOnly = true;
            this.textDonationStart.Size = new System.Drawing.Size(63, 20);
            this.textDonationStart.TabIndex = 1;
            this.textDonationStart.TabStop = false;
            this.textDonationStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textDonationEnd
            // 
            this.textDonationEnd.Location = new System.Drawing.Point(6, 70);
            this.textDonationEnd.Name = "textDonationEnd";
            this.textDonationEnd.ReadOnly = true;
            this.textDonationEnd.Size = new System.Drawing.Size(63, 20);
            this.textDonationEnd.TabIndex = 1;
            this.textDonationEnd.TabStop = false;
            this.textDonationEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Until";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mining TIme";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 603);
            this.Controls.Add(this.gbDonation);
            this.Controls.Add(this.dgServices);
            this.Controls.Add(this.dgPrices);
            this.Controls.Add(this.gbTimes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.gbActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Miner Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.gbActions.ResumeLayout(false);
            this.gbTimes.ResumeLayout(false);
            this.gbTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            this.gbDonation.ResumeLayout(false);
            this.gbDonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrPriceCheck;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.LinkLabel linkDonate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox gbTimes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer tmrTimeUpdate;
        private System.Windows.Forms.TextBox textRunningTotal;
        private System.Windows.Forms.TextBox textTimeCurrent;
        private System.Windows.Forms.Label lblTimeCurrent;
        private System.Windows.Forms.TextBox textTimeRestart;
        private System.Windows.Forms.TextBox textTimeSwitch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgPrices;
        private System.Windows.Forms.DataGridView dgServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceRunning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hashrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetEarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejectSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeMining;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPrint;
        private System.Windows.Forms.DataGridViewButtonColumn btnNhStart;
        private System.Windows.Forms.GroupBox gbDonation;
        private System.Windows.Forms.TextBox textDonationStart;
        private System.Windows.Forms.TextBox textDonationEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
