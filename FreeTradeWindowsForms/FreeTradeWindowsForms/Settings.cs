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
            double temp = 0; //used in parsing and then assigned to revelent fields.
          
            if (settingsCashBox.Text.Length>0  && double.TryParse(settingsCashBox.Text,out temp))
            {
                if (user.AddCash(temp)) {}

                else
                   MessageBox.Show("Cash is not greater than 0");
                
            }
            //add fees here.
            if (settingsFeesBox.Text.Length > 0 && double.TryParse(settingsCashBox.Text, out temp) && temp > 0)
                user.transactionFee= temp;
            else
                MessageBox.Show("Invalid entry in fees");

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

        private void settingsFeesBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
