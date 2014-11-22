namespace FreeTradeWindowsForms
{
    partial class WhatIf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatIf));
            this.label1 = new System.Windows.Forms.Label();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.purchasedSharesBox = new System.Windows.Forms.TextBox();
            this.whatButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.companySymbolBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "See what would happen if you were to buy a stock in the past.";
            // 
            // fromPicker
            // 
            this.fromPicker.Location = new System.Drawing.Point(15, 51);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(200, 20);
            this.fromPicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To: ";
            // 
            // toPicker
            // 
            this.toPicker.Location = new System.Drawing.Point(15, 101);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(200, 20);
            this.toPicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shares Purchased: ";
            // 
            // purchasedSharesBox
            // 
            this.purchasedSharesBox.Location = new System.Drawing.Point(15, 190);
            this.purchasedSharesBox.Name = "purchasedSharesBox";
            this.purchasedSharesBox.Size = new System.Drawing.Size(100, 20);
            this.purchasedSharesBox.TabIndex = 6;
            // 
            // whatButton
            // 
            this.whatButton.Location = new System.Drawing.Point(75, 227);
            this.whatButton.Name = "whatButton";
            this.whatButton.Size = new System.Drawing.Size(75, 23);
            this.whatButton.TabIndex = 7;
            this.whatButton.Text = "What If?";
            this.whatButton.UseVisualStyleBackColor = true;
            this.whatButton.Click += new System.EventHandler(this.whatButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Company Symbol:";
            // 
            // companySymbolBox
            // 
            this.companySymbolBox.Location = new System.Drawing.Point(15, 151);
            this.companySymbolBox.Name = "companySymbolBox";
            this.companySymbolBox.Size = new System.Drawing.Size(100, 20);
            this.companySymbolBox.TabIndex = 11;
            // 
            // WhatIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.companySymbolBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.whatButton);
            this.Controls.Add(this.purchasedSharesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromPicker);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhatIf";
            this.Text = "What If?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purchasedSharesBox;
        private System.Windows.Forms.Button whatButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companySymbolBox;
    }
}