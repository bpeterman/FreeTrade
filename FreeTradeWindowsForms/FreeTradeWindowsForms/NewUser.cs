using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeTradeWindowsForms.Controllers;

namespace FreeTradeWindowsForms
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent(); 
        }

        public string getUsername()
        {
            return newUserNameBox.Text;
        }

        public string getPassword()
        {
            return pass1Box.Text;
        }

        public string getPasswordVerification()
        {
            return pass2Box.Text;
        }

        public string getStartingCash()
        {
            return startCashBox.Text;
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    if (e.CloseReason == CloseReason.WindowsShutDown) return;

        //    if (pass1Box.Text != pass2Box.Text)
        //    {
        //        // Confirm user wants to close
        //        switch (MessageBox.Show(this, "Your passwords do not match.", "Incorrect Input", MessageBoxButtons.OK))
        //        {
        //            case DialogResult.OK:
        //                e.Cancel = true;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}

        private void addUserButton_Click(object sender, EventArgs e)
        {
            double startingCash;
            bool test = double.TryParse(getStartingCash(), out startingCash);
            if (string.IsNullOrEmpty(getUsername()) || 
                string.IsNullOrEmpty(getPassword()) || 
                string.IsNullOrEmpty(getPasswordVerification()) || 
                string.IsNullOrEmpty(getStartingCash()) ||
                !double.TryParse(getStartingCash(), out startingCash) ||
                pass1Box.Text != pass2Box.Text)
            {
                MessageBox.Show("Invalid information. Please try again.");
                return;
            }

            if (LoginController.isUser(getUsername()))
                MessageBox.Show("Username already exists.");
            else
            {
                LoginController.CreateNewUser(getUsername(), getPassword(), double.Parse(getStartingCash()));
                this.Close();
            }
        }
    }
}
