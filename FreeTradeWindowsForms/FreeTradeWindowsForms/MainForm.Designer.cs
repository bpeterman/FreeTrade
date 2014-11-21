namespace FreeTradeWindowsForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.marketStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.marketStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUserCash = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.overviewPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBoxWatchlist = new System.Windows.Forms.ListBox();
            this.NetWorthLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBoxTop5Loss = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxTop5Gains = new System.Windows.Forms.ListBox();
            this.TodaysReturnsLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalReturnsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.portfolioPage = new System.Windows.Forms.TabPage();
            this.portDataGrid = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tradePage = new System.Windows.Forms.TabPage();
            this.tradeSellButton = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
            this.tradeLow = new System.Windows.Forms.TextBox();
            this.tradeHigh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tradeIndustry = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tradeIPO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tradeExchange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tradeStockPrice = new System.Windows.Forms.TextBox();
            this.tradeSymbol = new System.Windows.Forms.TextBox();
            this.tradeCompanyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.transAmBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tradeNumOfShares = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.performancePage = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.overviewPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.portfolioPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portDataGrid)).BeginInit();
            this.tradePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.statusUsername,
            this.marketStatusText,
            this.marketStatus,
            this.toolStripStatusLabel1,
            this.statusUserCash});
            this.statusStrip.Location = new System.Drawing.Point(0, 546);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(756, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Market Status: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel2.Text = "Username: ";
            // 
            // statusUsername
            // 
            this.statusUsername.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold);
            this.statusUsername.Name = "statusUsername";
            this.statusUsername.Size = new System.Drawing.Size(34, 17);
            this.statusUsername.Text = "User";
            // 
            // marketStatusText
            // 
            this.marketStatusText.Name = "marketStatusText";
            this.marketStatusText.Size = new System.Drawing.Size(82, 17);
            this.marketStatusText.Text = "Market Status:";
            // 
            // marketStatus
            // 
            this.marketStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketStatus.ForeColor = System.Drawing.Color.Red;
            this.marketStatus.Name = "marketStatus";
            this.marketStatus.Size = new System.Drawing.Size(43, 17);
            this.marketStatus.Text = "Closed";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Cash: ";
            // 
            // statusUserCash
            // 
            this.statusUserCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusUserCash.ForeColor = System.Drawing.Color.Green;
            this.statusUserCash.Name = "statusUserCash";
            this.statusUserCash.Size = new System.Drawing.Size(21, 17);
            this.statusUserCash.Text = "$0";
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.overviewPage);
            this.mainTab.Controls.Add(this.portfolioPage);
            this.mainTab.Controls.Add(this.tradePage);
            this.mainTab.Controls.Add(this.performancePage);
            this.mainTab.Location = new System.Drawing.Point(0, 27);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(756, 516);
            this.mainTab.TabIndex = 2;
            this.mainTab.SelectedIndexChanged += new System.EventHandler(this.mainTab_SelectedIndexChanged);
            // 
            // overviewPage
            // 
            this.overviewPage.Controls.Add(this.groupBox3);
            this.overviewPage.Controls.Add(this.NetWorthLabel);
            this.overviewPage.Controls.Add(this.label16);
            this.overviewPage.Controls.Add(this.groupBox2);
            this.overviewPage.Controls.Add(this.groupBox1);
            this.overviewPage.Controls.Add(this.TodaysReturnsLabel);
            this.overviewPage.Controls.Add(this.label14);
            this.overviewPage.Controls.Add(this.TotalReturnsLabel);
            this.overviewPage.Controls.Add(this.label9);
            this.overviewPage.Location = new System.Drawing.Point(4, 22);
            this.overviewPage.Name = "overviewPage";
            this.overviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.overviewPage.Size = new System.Drawing.Size(748, 490);
            this.overviewPage.TabIndex = 0;
            this.overviewPage.Text = "Overview";
            this.overviewPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListBoxWatchlist);
            this.groupBox3.Location = new System.Drawing.Point(376, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 124);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Watchlist";
            // 
            // ListBoxWatchlist
            // 
            this.ListBoxWatchlist.FormattingEnabled = true;
            this.ListBoxWatchlist.Location = new System.Drawing.Point(6, 19);
            this.ListBoxWatchlist.Name = "ListBoxWatchlist";
            this.ListBoxWatchlist.Size = new System.Drawing.Size(352, 95);
            this.ListBoxWatchlist.TabIndex = 0;
            // 
            // NetWorthLabel
            // 
            this.NetWorthLabel.AutoSize = true;
            this.NetWorthLabel.Location = new System.Drawing.Point(108, 39);
            this.NetWorthLabel.Name = "NetWorthLabel";
            this.NetWorthLabel.Size = new System.Drawing.Size(61, 13);
            this.NetWorthLabel.TabIndex = 7;
            this.NetWorthLabel.Text = "$56,789.34";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Net Worth:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBoxTop5Loss);
            this.groupBox2.Location = new System.Drawing.Point(376, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 171);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 5 Losses";
            // 
            // ListBoxTop5Loss
            // 
            this.ListBoxTop5Loss.FormattingEnabled = true;
            this.ListBoxTop5Loss.Location = new System.Drawing.Point(6, 19);
            this.ListBoxTop5Loss.Name = "ListBoxTop5Loss";
            this.ListBoxTop5Loss.Size = new System.Drawing.Size(352, 147);
            this.ListBoxTop5Loss.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxTop5Gains);
            this.groupBox1.Location = new System.Drawing.Point(376, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top 5 Gainers";
            // 
            // ListBoxTop5Gains
            // 
            this.ListBoxTop5Gains.FormattingEnabled = true;
            this.ListBoxTop5Gains.Location = new System.Drawing.Point(6, 16);
            this.ListBoxTop5Gains.Name = "ListBoxTop5Gains";
            this.ListBoxTop5Gains.Size = new System.Drawing.Size(352, 147);
            this.ListBoxTop5Gains.TabIndex = 0;
            // 
            // TodaysReturnsLabel
            // 
            this.TodaysReturnsLabel.AutoSize = true;
            this.TodaysReturnsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TodaysReturnsLabel.Location = new System.Drawing.Point(105, 22);
            this.TodaysReturnsLabel.Name = "TodaysReturnsLabel";
            this.TodaysReturnsLabel.Size = new System.Drawing.Size(13, 13);
            this.TodaysReturnsLabel.TabIndex = 3;
            this.TodaysReturnsLabel.Text = "--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Today\'s Returns: ";
            // 
            // TotalReturnsLabel
            // 
            this.TotalReturnsLabel.AutoSize = true;
            this.TotalReturnsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalReturnsLabel.Location = new System.Drawing.Point(106, 5);
            this.TotalReturnsLabel.Name = "TotalReturnsLabel";
            this.TotalReturnsLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalReturnsLabel.TabIndex = 1;
            this.TotalReturnsLabel.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Returns:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // portfolioPage
            // 
            this.portfolioPage.Controls.Add(this.portDataGrid);
            this.portfolioPage.Controls.Add(this.webBrowser1);
            this.portfolioPage.Location = new System.Drawing.Point(4, 22);
            this.portfolioPage.Name = "portfolioPage";
            this.portfolioPage.Padding = new System.Windows.Forms.Padding(3);
            this.portfolioPage.Size = new System.Drawing.Size(748, 490);
            this.portfolioPage.TabIndex = 1;
            this.portfolioPage.Text = "Portfolio";
            this.portfolioPage.UseVisualStyleBackColor = true;
            // 
            // portDataGrid
            // 
            this.portDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portDataGrid.Location = new System.Drawing.Point(0, 0);
            this.portDataGrid.Name = "portDataGrid";
            this.portDataGrid.Size = new System.Drawing.Size(728, 490);
            this.portDataGrid.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(742, 484);
            this.webBrowser1.TabIndex = 0;
            // 
            // tradePage
            // 
            this.tradePage.Controls.Add(this.tradeSellButton);
            this.tradePage.Controls.Add(this.watchButton);
            this.tradePage.Controls.Add(this.tradeLow);
            this.tradePage.Controls.Add(this.tradeHigh);
            this.tradePage.Controls.Add(this.label13);
            this.tradePage.Controls.Add(this.label12);
            this.tradePage.Controls.Add(this.tradeIndustry);
            this.tradePage.Controls.Add(this.label11);
            this.tradePage.Controls.Add(this.tradeIPO);
            this.tradePage.Controls.Add(this.label8);
            this.tradePage.Controls.Add(this.tradeExchange);
            this.tradePage.Controls.Add(this.label7);
            this.tradePage.Controls.Add(this.tradeStockPrice);
            this.tradePage.Controls.Add(this.tradeSymbol);
            this.tradePage.Controls.Add(this.tradeCompanyName);
            this.tradePage.Controls.Add(this.label6);
            this.tradePage.Controls.Add(this.label5);
            this.tradePage.Controls.Add(this.label4);
            this.tradePage.Controls.Add(this.buyButton);
            this.tradePage.Controls.Add(this.transAmBox);
            this.tradePage.Controls.Add(this.label3);
            this.tradePage.Controls.Add(this.tradeNumOfShares);
            this.tradePage.Controls.Add(this.label2);
            this.tradePage.Controls.Add(this.searchResults);
            this.tradePage.Controls.Add(this.searchButton);
            this.tradePage.Controls.Add(this.searchBox);
            this.tradePage.Controls.Add(this.label1);
            this.tradePage.Location = new System.Drawing.Point(4, 22);
            this.tradePage.Name = "tradePage";
            this.tradePage.Padding = new System.Windows.Forms.Padding(3);
            this.tradePage.Size = new System.Drawing.Size(748, 490);
            this.tradePage.TabIndex = 2;
            this.tradePage.Text = "Trade";
            this.tradePage.UseVisualStyleBackColor = true;
            // 
            // tradeSellButton
            // 
            this.tradeSellButton.Location = new System.Drawing.Point(655, 455);
            this.tradeSellButton.Name = "tradeSellButton";
            this.tradeSellButton.Size = new System.Drawing.Size(39, 23);
            this.tradeSellButton.TabIndex = 30;
            this.tradeSellButton.Text = "Sell";
            this.tradeSellButton.UseVisualStyleBackColor = true;
            this.tradeSellButton.Click += new System.EventHandler(this.tradeSellButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.Location = new System.Drawing.Point(381, 284);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(105, 23);
            this.watchButton.TabIndex = 29;
            this.watchButton.Text = "Add to Watchlist";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // tradeLow
            // 
            this.tradeLow.Location = new System.Drawing.Point(303, 238);
            this.tradeLow.Name = "tradeLow";
            this.tradeLow.ReadOnly = true;
            this.tradeLow.Size = new System.Drawing.Size(269, 20);
            this.tradeLow.TabIndex = 28;
            // 
            // tradeHigh
            // 
            this.tradeHigh.Location = new System.Drawing.Point(303, 209);
            this.tradeHigh.Name = "tradeHigh";
            this.tradeHigh.ReadOnly = true;
            this.tradeHigh.Size = new System.Drawing.Size(269, 20);
            this.tradeHigh.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "52 Week Low: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "52 Week High: ";
            // 
            // tradeIndustry
            // 
            this.tradeIndustry.Location = new System.Drawing.Point(303, 178);
            this.tradeIndustry.Name = "tradeIndustry";
            this.tradeIndustry.ReadOnly = true;
            this.tradeIndustry.Size = new System.Drawing.Size(269, 20);
            this.tradeIndustry.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Industry: ";
            // 
            // tradeIPO
            // 
            this.tradeIPO.Location = new System.Drawing.Point(303, 144);
            this.tradeIPO.Name = "tradeIPO";
            this.tradeIPO.ReadOnly = true;
            this.tradeIPO.Size = new System.Drawing.Size(269, 20);
            this.tradeIPO.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "IPO Year: ";
            // 
            // tradeExchange
            // 
            this.tradeExchange.Location = new System.Drawing.Point(303, 113);
            this.tradeExchange.Name = "tradeExchange";
            this.tradeExchange.ReadOnly = true;
            this.tradeExchange.Size = new System.Drawing.Size(269, 20);
            this.tradeExchange.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Exchange: ";
            // 
            // tradeStockPrice
            // 
            this.tradeStockPrice.Location = new System.Drawing.Point(303, 87);
            this.tradeStockPrice.Name = "tradeStockPrice";
            this.tradeStockPrice.ReadOnly = true;
            this.tradeStockPrice.Size = new System.Drawing.Size(269, 20);
            this.tradeStockPrice.TabIndex = 15;
            // 
            // tradeSymbol
            // 
            this.tradeSymbol.Location = new System.Drawing.Point(303, 61);
            this.tradeSymbol.Name = "tradeSymbol";
            this.tradeSymbol.ReadOnly = true;
            this.tradeSymbol.Size = new System.Drawing.Size(269, 20);
            this.tradeSymbol.TabIndex = 14;
            // 
            // tradeCompanyName
            // 
            this.tradeCompanyName.Location = new System.Drawing.Point(303, 33);
            this.tradeCompanyName.Name = "tradeCompanyName";
            this.tradeCompanyName.ReadOnly = true;
            this.tradeCompanyName.Size = new System.Drawing.Size(269, 20);
            this.tradeCompanyName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Stock Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Symbol: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company Name: ";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(700, 455);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(40, 23);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // transAmBox
            // 
            this.transAmBox.Location = new System.Drawing.Point(523, 457);
            this.transAmBox.Name = "transAmBox";
            this.transAmBox.ReadOnly = true;
            this.transAmBox.Size = new System.Drawing.Size(126, 20);
            this.transAmBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaction Amount: ";
            // 
            // tradeNumOfShares
            // 
            this.tradeNumOfShares.Location = new System.Drawing.Point(101, 457);
            this.tradeNumOfShares.Name = "tradeNumOfShares";
            this.tradeNumOfShares.Size = new System.Drawing.Size(312, 20);
            this.tradeNumOfShares.TabIndex = 5;
            this.tradeNumOfShares.TextChanged += new System.EventHandler(this.tradeNumOfShares_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Shares: ";
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.Location = new System.Drawing.Point(10, 36);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(183, 394);
            this.searchResults.TabIndex = 3;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.searchResults_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(665, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(195, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(454, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchButton_Click);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Stock Symbol / Company Name: ";
            // 
            // performancePage
            // 
            this.performancePage.Location = new System.Drawing.Point(4, 22);
            this.performancePage.Name = "performancePage";
            this.performancePage.Padding = new System.Windows.Forms.Padding(3);
            this.performancePage.Size = new System.Drawing.Size(748, 490);
            this.performancePage.TabIndex = 3;
            this.performancePage.Text = "Performance";
            this.performancePage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 568);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Free Trade";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.overviewPage.ResumeLayout(false);
            this.overviewPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.portfolioPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portDataGrid)).EndInit();
            this.tradePage.ResumeLayout(false);
            this.tradePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel marketStatusText;
        private System.Windows.Forms.ToolStripStatusLabel marketStatus;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage overviewPage;
        private System.Windows.Forms.TabPage portfolioPage;
        private System.Windows.Forms.TabPage tradePage;
        private System.Windows.Forms.TabPage performancePage;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox transAmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tradeNumOfShares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tradeStockPrice;
        private System.Windows.Forms.TextBox tradeSymbol;
        private System.Windows.Forms.TextBox tradeCompanyName;
        private System.Windows.Forms.TextBox tradeExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tradeIPO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusUserCash;
        private System.Windows.Forms.TextBox tradeIndustry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tradeLow;
        private System.Windows.Forms.TextBox tradeHigh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView portDataGrid;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBoxTop5Loss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBoxTop5Gains;
        private System.Windows.Forms.Label TodaysReturnsLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TotalReturnsLabel;
        private System.Windows.Forms.Label NetWorthLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListBoxWatchlist;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Button tradeSellButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusUsername;
    }
}

