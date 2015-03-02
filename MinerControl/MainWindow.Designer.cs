namespace MinerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrPriceCheck = new System.Windows.Forms.Timer(this.components);
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnReloadConfig = new System.Windows.Forms.Button();
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
            this.dgServices = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceRunning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDonation = new System.Windows.Forms.GroupBox();
            this.textDonationStart = new System.Windows.Forms.TextBox();
            this.textDonationEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCurrency = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCurrencyBalance = new System.Windows.Forms.TextBox();
            this.textCurrencyExchange = new System.Windows.Forms.TextBox();
            this.tmrExchangeUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPrices = new System.Windows.Forms.TabPage();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.textConsole = new System.Windows.Forms.TextBox();
            this.tabRemote = new System.Windows.Forms.TabPage();
            this.textRemote = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hashrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetEarn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeMining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhStart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbActions.SuspendLayout();
            this.gbTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            this.gbDonation.SuspendLayout();
            this.gbCurrency.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPrices.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabRemote.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Auto";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 20);
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
            this.gbActions.Controls.Add(this.btnReloadConfig);
            this.gbActions.Controls.Add(this.btnStop);
            this.gbActions.Controls.Add(this.btnStart);
            this.gbActions.Location = new System.Drawing.Point(16, 31);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(62, 96);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnReloadConfig
            // 
            this.btnReloadConfig.Location = new System.Drawing.Point(6, 69);
            this.btnReloadConfig.Name = "btnReloadConfig";
            this.btnReloadConfig.Size = new System.Drawing.Size(50, 20);
            this.btnReloadConfig.TabIndex = 10;
            this.btnReloadConfig.Text = "Reload";
            this.btnReloadConfig.UseVisualStyleBackColor = true;
            this.btnReloadConfig.Click += new System.EventHandler(this.btnReloadConfig_Click);
            // 
            // linkDonate
            // 
            this.linkDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDonate.AutoSize = true;
            this.linkDonate.LinkArea = new System.Windows.Forms.LinkArea(45, 34);
            this.linkDonate.Location = new System.Drawing.Point(16, 577);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(764, 17);
            this.linkDonate.TabIndex = 9;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "If you like this, please donate some mBTC to 1F9fsG5xLLn6uc7cdbgV1LTFWjWQSqXohX (" +
    "KBomba, donation mining rounds still go to StuffOfInterest)\r\n";
            this.linkDonate.UseCompatibleTextRendering = true;
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Miner Control v1.6.3 (KBomba-Mod)";
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
            this.dgPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Id,
            this.ServicePrint,
            this.Algo,
            this.Hashrate,
            this.Price,
            this.Earn,
            this.Fees,
            this.PowerCost,
            this.NetEarn,
            this.NetAverage,
            this.Balance,
            this.AcceptSpeed,
            this.RejectSpeed,
            this.TimeMining,
            this.StatusPrint,
            this.btnNhStart});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPrices.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgPrices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPrices.Location = new System.Drawing.Point(6, 6);
            this.dgPrices.MultiSelect = false;
            this.dgPrices.Name = "dgPrices";
            this.dgPrices.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgPrices.RowHeadersVisible = false;
            this.dgPrices.ShowCellErrors = false;
            this.dgPrices.ShowCellToolTips = false;
            this.dgPrices.ShowEditingIcon = false;
            this.dgPrices.ShowRowErrors = false;
            this.dgPrices.Size = new System.Drawing.Size(903, 367);
            this.dgPrices.TabIndex = 12;
            this.dgPrices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrices_CellContentClick);
            this.dgPrices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPrices_CellMouseDoubleClick);
            // 
            // dgServices
            // 
            this.dgServices.AllowUserToAddRows = false;
            this.dgServices.AllowUserToDeleteRows = false;
            this.dgServices.AllowUserToResizeColumns = false;
            this.dgServices.AllowUserToResizeRows = false;
            this.dgServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceLastUpdated,
            this.ServiceBalance,
            this.ServiceCurrency,
            this.ServiceRunning});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgServices.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgServices.Location = new System.Drawing.Point(464, 9);
            this.dgServices.Name = "dgServices";
            this.dgServices.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgServices.RowHeadersVisible = false;
            this.dgServices.ShowCellErrors = false;
            this.dgServices.ShowCellToolTips = false;
            this.dgServices.ShowEditingIcon = false;
            this.dgServices.ShowRowErrors = false;
            this.dgServices.Size = new System.Drawing.Size(466, 140);
            this.dgServices.TabIndex = 13;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "ServicePrint";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ServiceName.DefaultCellStyle = dataGridViewCellStyle16;
            this.ServiceName.HeaderText = "Service";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ServiceLastUpdated
            // 
            this.ServiceLastUpdated.DataPropertyName = "LastUpdatedPrint";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceLastUpdated.DefaultCellStyle = dataGridViewCellStyle17;
            this.ServiceLastUpdated.HeaderText = "Updated";
            this.ServiceLastUpdated.Name = "ServiceLastUpdated";
            this.ServiceLastUpdated.ReadOnly = true;
            this.ServiceLastUpdated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceLastUpdated.Width = 65;
            // 
            // ServiceBalance
            // 
            this.ServiceBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceBalance.DataPropertyName = "BalancePrint";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceBalance.DefaultCellStyle = dataGridViewCellStyle18;
            this.ServiceBalance.HeaderText = "Balance";
            this.ServiceBalance.Name = "ServiceBalance";
            this.ServiceBalance.ReadOnly = true;
            this.ServiceBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ServiceCurrency
            // 
            this.ServiceCurrency.DataPropertyName = "CurrencyPrint";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceCurrency.DefaultCellStyle = dataGridViewCellStyle19;
            this.ServiceCurrency.HeaderText = "Currency";
            this.ServiceCurrency.Name = "ServiceCurrency";
            this.ServiceCurrency.ReadOnly = true;
            this.ServiceCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceCurrency.Width = 65;
            // 
            // ServiceRunning
            // 
            this.ServiceRunning.DataPropertyName = "TimeMiningPrint";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ServiceRunning.DefaultCellStyle = dataGridViewCellStyle20;
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
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mining Time";
            // 
            // gbCurrency
            // 
            this.gbCurrency.Controls.Add(this.label4);
            this.gbCurrency.Controls.Add(this.lblCurrencySymbol);
            this.gbCurrency.Controls.Add(this.label3);
            this.gbCurrency.Controls.Add(this.textCurrencyBalance);
            this.gbCurrency.Controls.Add(this.textCurrencyExchange);
            this.gbCurrency.Location = new System.Drawing.Point(336, 31);
            this.gbCurrency.Name = "gbCurrency";
            this.gbCurrency.Size = new System.Drawing.Size(107, 96);
            this.gbCurrency.TabIndex = 15;
            this.gbCurrency.TabStop = false;
            this.gbCurrency.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balance";
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(73, 74);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(30, 13);
            this.lblCurrencySymbol.TabIndex = 0;
            this.lblCurrencySymbol.Text = "USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exchange";
            // 
            // textCurrencyBalance
            // 
            this.textCurrencyBalance.Location = new System.Drawing.Point(9, 70);
            this.textCurrencyBalance.Name = "textCurrencyBalance";
            this.textCurrencyBalance.ReadOnly = true;
            this.textCurrencyBalance.Size = new System.Drawing.Size(63, 20);
            this.textCurrencyBalance.TabIndex = 1;
            this.textCurrencyBalance.TabStop = false;
            this.textCurrencyBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCurrencyExchange
            // 
            this.textCurrencyExchange.Location = new System.Drawing.Point(9, 33);
            this.textCurrencyExchange.Name = "textCurrencyExchange";
            this.textCurrencyExchange.ReadOnly = true;
            this.textCurrencyExchange.Size = new System.Drawing.Size(63, 20);
            this.textCurrencyExchange.TabIndex = 1;
            this.textCurrencyExchange.TabStop = false;
            this.textCurrencyExchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmrExchangeUpdate
            // 
            this.tmrExchangeUpdate.Interval = 1800000;
            this.tmrExchangeUpdate.Tick += new System.EventHandler(this.tmrExchangeUpdate_Tick);
            // 
            // tabPage
            // 
            this.tabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPage.Controls.Add(this.tabPrices);
            this.tabPage.Controls.Add(this.tabConsole);
            this.tabPage.Controls.Add(this.tabRemote);
            this.tabPage.Location = new System.Drawing.Point(12, 155);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(923, 405);
            this.tabPage.TabIndex = 16;
            // 
            // tabPrices
            // 
            this.tabPrices.Controls.Add(this.dgPrices);
            this.tabPrices.Location = new System.Drawing.Point(4, 22);
            this.tabPrices.Name = "tabPrices";
            this.tabPrices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrices.Size = new System.Drawing.Size(915, 379);
            this.tabPrices.TabIndex = 0;
            this.tabPrices.Text = "Prices";
            this.tabPrices.UseVisualStyleBackColor = true;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.textConsole);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(803, 379);
            this.tabConsole.TabIndex = 1;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // textConsole
            // 
            this.textConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textConsole.BackColor = System.Drawing.Color.Black;
            this.textConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConsole.ForeColor = System.Drawing.Color.White;
            this.textConsole.Location = new System.Drawing.Point(7, 7);
            this.textConsole.Multiline = true;
            this.textConsole.Name = "textConsole";
            this.textConsole.ReadOnly = true;
            this.textConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textConsole.Size = new System.Drawing.Size(790, 366);
            this.textConsole.TabIndex = 0;
            // 
            // tabRemote
            // 
            this.tabRemote.Controls.Add(this.textRemote);
            this.tabRemote.Location = new System.Drawing.Point(4, 22);
            this.tabRemote.Name = "tabRemote";
            this.tabRemote.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemote.Size = new System.Drawing.Size(803, 379);
            this.tabRemote.TabIndex = 2;
            this.tabRemote.Text = "Remote";
            this.tabRemote.UseVisualStyleBackColor = true;
            // 
            // textRemote
            // 
            this.textRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRemote.BackColor = System.Drawing.Color.Black;
            this.textRemote.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemote.ForeColor = System.Drawing.Color.White;
            this.textRemote.Location = new System.Drawing.Point(6, 6);
            this.textRemote.Multiline = true;
            this.textRemote.Name = "textRemote";
            this.textRemote.ReadOnly = true;
            this.textRemote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textRemote.Size = new System.Drawing.Size(790, 366);
            this.textRemote.TabIndex = 1;
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
            this.ServicePrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServicePrint.DataPropertyName = "ServicePrint";
            this.ServicePrint.HeaderText = "Service";
            this.ServicePrint.MinimumWidth = 50;
            this.ServicePrint.Name = "ServicePrint";
            this.ServicePrint.ReadOnly = true;
            // 
            // Algo
            // 
            this.Algo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Algo.DataPropertyName = "Name";
            this.Algo.HeaderText = "Algo";
            this.Algo.MinimumWidth = 50;
            this.Algo.Name = "Algo";
            this.Algo.ReadOnly = true;
            // 
            // Hashrate
            // 
            this.Hashrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hashrate.DataPropertyName = "Hashrate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Hashrate.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hashrate.HeaderText = "Hash";
            this.Hashrate.MinimumWidth = 50;
            this.Hashrate.Name = "Hashrate";
            this.Hashrate.ReadOnly = true;
            this.Hashrate.ToolTipText = "Kh/sec";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N6";
            dataGridViewCellStyle3.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.ToolTipText = "BTC/GH/day";
            this.Price.Width = 60;
            // 
            // Earn
            // 
            this.Earn.DataPropertyName = "Earn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.Earn.DefaultCellStyle = dataGridViewCellStyle4;
            this.Earn.HeaderText = "Earn";
            this.Earn.Name = "Earn";
            this.Earn.ReadOnly = true;
            this.Earn.ToolTipText = "BTC/day";
            this.Earn.Width = 60;
            // 
            // Fees
            // 
            this.Fees.DataPropertyName = "Fees";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N6";
            this.Fees.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            this.Fees.ToolTipText = "BTC/day";
            this.Fees.Width = 60;
            // 
            // PowerCost
            // 
            this.PowerCost.DataPropertyName = "PowerCost";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = null;
            this.PowerCost.DefaultCellStyle = dataGridViewCellStyle6;
            this.PowerCost.HeaderText = "Power";
            this.PowerCost.Name = "PowerCost";
            this.PowerCost.ReadOnly = true;
            this.PowerCost.ToolTipText = "BTC/day";
            this.PowerCost.Width = 60;
            // 
            // NetEarn
            // 
            this.NetEarn.DataPropertyName = "NetEarn";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N6";
            dataGridViewCellStyle7.NullValue = null;
            this.NetEarn.DefaultCellStyle = dataGridViewCellStyle7;
            this.NetEarn.HeaderText = "Net";
            this.NetEarn.Name = "NetEarn";
            this.NetEarn.ReadOnly = true;
            this.NetEarn.ToolTipText = "BTC/day";
            this.NetEarn.Width = 60;
            // 
            // NetAverage
            // 
            this.NetAverage.DataPropertyName = "NetAverage";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N6";
            this.NetAverage.DefaultCellStyle = dataGridViewCellStyle8;
            this.NetAverage.HeaderText = "Average";
            this.NetAverage.Name = "NetAverage";
            this.NetAverage.ReadOnly = true;
            this.NetAverage.ToolTipText = "BTC/day";
            this.NetAverage.Width = 60;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "BalancePrint";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.NullValue = null;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle9;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.ToolTipText = "BTC";
            this.Balance.Width = 65;
            // 
            // AcceptSpeed
            // 
            this.AcceptSpeed.DataPropertyName = "AcceptSpeedPrint";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = null;
            this.AcceptSpeed.DefaultCellStyle = dataGridViewCellStyle10;
            this.AcceptSpeed.HeaderText = "Accept";
            this.AcceptSpeed.Name = "AcceptSpeed";
            this.AcceptSpeed.ReadOnly = true;
            this.AcceptSpeed.Width = 45;
            // 
            // RejectSpeed
            // 
            this.RejectSpeed.DataPropertyName = "RejectSpeedPrint";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.NullValue = null;
            this.RejectSpeed.DefaultCellStyle = dataGridViewCellStyle11;
            this.RejectSpeed.HeaderText = "Reject";
            this.RejectSpeed.Name = "RejectSpeed";
            this.RejectSpeed.ReadOnly = true;
            this.RejectSpeed.Width = 45;
            // 
            // TimeMining
            // 
            this.TimeMining.DataPropertyName = "TimeMiningPrint";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TimeMining.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.StatusPrint.Width = 55;
            // 
            // btnNhStart
            // 
            this.btnNhStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnNhStart.HeaderText = "Action";
            this.btnNhStart.MinimumWidth = 55;
            this.btnNhStart.Name = "btnNhStart";
            this.btnNhStart.ReadOnly = true;
            this.btnNhStart.Text = "Start";
            this.btnNhStart.UseColumnTextForButtonValue = true;
            this.btnNhStart.Width = 55;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 603);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.gbCurrency);
            this.Controls.Add(this.gbDonation);
            this.Controls.Add(this.dgServices);
            this.Controls.Add(this.gbTimes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.gbActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Miner Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.gbActions.ResumeLayout(false);
            this.gbTimes.ResumeLayout(false);
            this.gbTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            this.gbDonation.ResumeLayout(false);
            this.gbDonation.PerformLayout();
            this.gbCurrency.ResumeLayout(false);
            this.gbCurrency.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPrices.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.tabRemote.ResumeLayout(false);
            this.tabRemote.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbDonation;
        private System.Windows.Forms.TextBox textDonationStart;
        private System.Windows.Forms.TextBox textDonationEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCurrencyExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCurrencyBalance;
        private System.Windows.Forms.Timer tmrExchangeUpdate;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPrices;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TextBox textConsole;
        private System.Windows.Forms.TabPage tabRemote;
        private System.Windows.Forms.TextBox textRemote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceRunning;
        private System.Windows.Forms.Button btnReloadConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hashrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetEarn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejectSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeMining;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPrint;
        private System.Windows.Forms.DataGridViewButtonColumn btnNhStart;
    }
}

