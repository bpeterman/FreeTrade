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
using FreeTradeWindowsForms.Models;

namespace FreeTradeWindowsForms
{
    public partial class Settings : Form
    {
        User user;
        public Settings(User user)
        {
            InitializeComponent();
            this.user = user;
            if (!user.EnforceMarketClosure) 
            {
                marketCloseBox.Text = "No";
            }
            settingsFeesBox.Text = user.transactionFee.ToString();
        }

        public User getUser()
        {
            return user;
        }

        public string getCash()
        {
            return settingsCashBox.Text;
        }

        public string getFees()
        {
            return settingsFeesBox.Text;
        }
                
        public string getEnforcement()
        {
            return marketCloseBox.Text;
        }

        private void settingsSaveButton_Click(object sender, EventArgs e)
        {
            //add to cash here.
            if (settingsCashBox.Text.Length>0)
                user.AddCash(Convert.ToDouble(settingsCashBox.Text));
            //add fees here.
            if (settingsFeesBox.Text.Length > 0)
                user.transactionFee= Convert.ToDouble(settingsFeesBox.Text);

            //set market enforcement
            if (getEnforcement().Equals("Yes"))
            {
                user.EnforceMarketClosure = true;
            }
            else
            {
                user.EnforceMarketClosure = false;
            }

            //close the settings window.
            this.Close();
            MessageBox.Show("Settings changed.");
        }
    }
}
