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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tradePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.tradePage.Controls.Add(this.searchResults);
            this.tradePage.Controls.Add(this.searchButton);
            this.tradePage.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 20);
            this.textBox1.TabIndex = 1;
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
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.Location = new System.Drawing.Point(10, 36);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(183, 446);
            this.searchResults.TabIndex = 3;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

