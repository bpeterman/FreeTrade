namespace FreeTradeWindowsForms
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.newUserNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass1Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass2Box = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.startCashBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // newUserNameBox
            // 
            this.newUserNameBox.Location = new System.Drawing.Point(129, 28);
            this.newUserNameBox.Name = "newUserNameBox";
            this.newUserNameBox.Size = new System.Drawing.Size(100, 20);
            this.newUserNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // pass1Box
            // 
            this.pass1Box.Location = new System.Drawing.Point(129, 56);
            this.pass1Box.Name = "pass1Box";
            this.pass1Box.PasswordChar = '*';
            this.pass1Box.Size = new System.Drawing.Size(100, 20);
            this.pass1Box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter Password:";
            // 
            // pass2Box
            // 
            this.pass2Box.Location = new System.Drawing.Point(129, 82);
            this.pass2Box.Name = "pass2Box";
            this.pass2Box.PasswordChar = '*';
            this.pass2Box.Size = new System.Drawing.Size(100, 20);
            this.pass2Box.TabIndex = 5;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(98, 163);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Submit";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting Cash: ";
            // 
            // startCashBox
            // 
            this.startCashBox.Location = new System.Drawing.Point(130, 122);
            this.startCashBox.Name = "startCashBox";
            this.startCashBox.Size = new System.Drawing.Size(100, 20);
            this.startCashBox.TabIndex = 8;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 207);
            this.Controls.Add(this.startCashBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.pass2Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass1Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newUserNameBox);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass1Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass2Box;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startCashBox;
    }
}