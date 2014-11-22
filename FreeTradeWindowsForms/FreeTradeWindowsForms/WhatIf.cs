using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeTradeWindowsForms
{
    public partial class WhatIf : Form
    {
        public WhatIf()
        {
            InitializeComponent();
        }

        private void whatButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime from = fromPicker.Value;
                DateTime to = toPicker.Value;
                Stock stock = new Stock();
                string[] splitResults = stock.getHistory(companySymbolBox.Text, from, from, 'm').Split(new Char[] { ',' });
                double fromPrice = Convert.ToDouble(splitResults[7]);
                splitResults = stock.getHistory(companySymbolBox.Text, to, to, 'm').Split(new Char[] { ',' });
                double toPrice = Convert.ToDouble(splitResults[7]);
                int numShares = Convert.ToInt32(purchasedSharesBox.Text);
                double profit = (toPrice - fromPrice) * numShares;
                if (profit >= 0)
                    MessageBox.Show("You would have made " + profit.ToString("C2") + " had you bought " + numShares + " share(s) of " + companySymbolBox.Text + " in " + from.Year + " and then sold in " + to.Year + "\nFrom: " + fromPrice.ToString("C2") + "\nTo: " + toPrice.ToString("C2"));
                else
                    MessageBox.Show("You would have lost " + profit.ToString("C2") + " had you bought " + numShares + " share(s) of " + companySymbolBox.Text + " in " + from.Year + " and then sold in " + to.Year + "\nFrom: " + fromPrice.ToString("C2") + "\nTo: " + toPrice.ToString("C2"));
            }
            catch
            {
                MessageBox.Show("Something is wrong with this.");
            }
        }
    }
}
