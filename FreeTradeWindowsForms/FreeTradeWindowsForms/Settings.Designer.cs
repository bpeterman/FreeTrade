namespace FreeTradeWindowsForms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.settingsCashBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsFeesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marketCloseBox = new System.Windows.Forms.ComboBox();
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add to Cash: ";
            // 
            // settingsCashBox
            // 
            this.settingsCashBox.Location = new System.Drawing.Point(164, 26);
            this.settingsCashBox.Name = "settingsCashBox";
            this.settingsCashBox.Size = new System.Drawing.Size(100, 20);
            this.settingsCashBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fee\'s: ";
            // 
            // settingsFeesBox
            // 
            this.settingsFeesBox.Location = new System.Drawing.Point(164, 58);
            this.settingsFeesBox.Name = "settingsFeesBox";
            this.settingsFeesBox.Size = new System.Drawing.Size(100, 20);
            this.settingsFeesBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enforce Market Closures: ";
            // 
            // marketCloseBox
            // 
            this.marketCloseBox.FormattingEnabled = true;
            this.marketCloseBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.marketCloseBox.Location = new System.Drawing.Point(164, 88);
            this.marketCloseBox.Name = "marketCloseBox";
            this.marketCloseBox.Size = new System.Drawing.Size(100, 21);
            this.marketCloseBox.TabIndex = 5;
            this.marketCloseBox.Text = "Yes";
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.Location = new System.Drawing.Point(189, 282);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.settingsSaveButton.TabIndex = 6;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.settingsSaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.settingsSaveButton);
            this.Controls.Add(this.marketCloseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.settingsFeesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsCashBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox settingsCashBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox settingsFeesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox marketCloseBox;
        private System.Windows.Forms.Button settingsSaveButton;
    }
}