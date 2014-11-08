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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.marketStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.marketStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.overviewPage = new System.Windows.Forms.TabPage();
            this.portfolioPage = new System.Windows.Forms.TabPage();
            this.tradePage = new System.Windows.Forms.TabPage();
            this.performancePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transAmBox = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tradeCompanyName = new System.Windows.Forms.TextBox();
            this.tradeSymbol = new System.Windows.Forms.TextBox();
            this.tradeStockPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tradeExchange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tradeIPO = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTab.SuspendLayout();
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
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketStatusText,
            this.marketStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 546);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(756, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Market Status: ";
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
            // 
            // overviewPage
            // 
            this.overviewPage.Location = new System.Drawing.Point(4, 22);
            this.overviewPage.Name = "overviewPage";
            this.overviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.overviewPage.Size = new System.Drawing.Size(748, 490);
            this.overviewPage.TabIndex = 0;
            this.overviewPage.Text = "Overview";
            this.overviewPage.UseVisualStyleBackColor = true;
            // 
            // portfolioPage
            // 
            this.portfolioPage.Location = new System.Drawing.Point(4, 22);
            this.portfolioPage.Name = "portfolioPage";
            this.portfolioPage.Padding = new System.Windows.Forms.Padding(3);
            this.portfolioPage.Size = new System.Drawing.Size(748, 490);
            this.portfolioPage.TabIndex = 1;
            this.portfolioPage.Text = "Portfolio";
            this.portfolioPage.UseVisualStyleBackColor = true;
            // 
            // tradePage
            // 
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
            this.tradePage.Controls.Add(this.sellButton);
            this.tradePage.Controls.Add(this.transAmBox);
            this.tradePage.Controls.Add(this.label3);
            this.tradePage.Controls.Add(this.textBox2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Stock Symbol / Company Name: ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(195, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(454, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchEnter);
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
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.Location = new System.Drawing.Point(10, 36);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(183, 394);
            this.searchResults.TabIndex = 3;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.searchResults_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Shares: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 20);
            this.textBox2.TabIndex = 5;
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
            // transAmBox
            // 
            this.transAmBox.Location = new System.Drawing.Point(523, 457);
            this.transAmBox.Name = "transAmBox";
            this.transAmBox.Size = new System.Drawing.Size(100, 20);
            this.transAmBox.TabIndex = 7;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(629, 457);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(50, 23);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(685, 457);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(48, 23);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Symbol: ";
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
            // tradeCompanyName
            // 
            this.tradeCompanyName.Location = new System.Drawing.Point(303, 33);
            this.tradeCompanyName.Name = "tradeCompanyName";
            this.tradeCompanyName.ReadOnly = true;
            this.tradeCompanyName.Size = new System.Drawing.Size(269, 20);
            this.tradeCompanyName.TabIndex = 13;
            // 
            // tradeSymbol
            // 
            this.tradeSymbol.Location = new System.Drawing.Point(303, 61);
            this.tradeSymbol.Name = "tradeSymbol";
            this.tradeSymbol.ReadOnly = true;
            this.tradeSymbol.Size = new System.Drawing.Size(269, 20);
            this.tradeSymbol.TabIndex = 14;
            // 
            // tradeStockPrice
            // 
            this.tradeStockPrice.Location = new System.Drawing.Point(303, 87);
            this.tradeStockPrice.Name = "tradeStockPrice";
            this.tradeStockPrice.ReadOnly = true;
            this.tradeStockPrice.Size = new System.Drawing.Size(269, 20);
            this.tradeStockPrice.TabIndex = 15;
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
            // tradeExchange
            // 
            this.tradeExchange.Location = new System.Drawing.Point(303, 113);
            this.tradeExchange.Name = "tradeExchange";
            this.tradeExchange.ReadOnly = true;
            this.tradeExchange.Size = new System.Drawing.Size(269, 20);
            this.tradeExchange.TabIndex = 17;
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
            // tradeIPO
            // 
            this.tradeIPO.Location = new System.Drawing.Point(303, 144);
            this.tradeIPO.Name = "tradeIPO";
            this.tradeIPO.ReadOnly = true;
            this.tradeIPO.Size = new System.Drawing.Size(269, 20);
            this.tradeIPO.TabIndex = 19;
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
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TextBox transAmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

