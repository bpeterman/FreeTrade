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
    public partial class MainForm : Form
    {
        List<UserProfile> users = new List<UserProfile>();
        List<Company> results = new List<Company>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            results = new List<Company>();
            searchResults.Items.Clear();
            string query = searchBox.Text;
            Search search = new Search();
            results = search.search(query);
            if (results != null)
            {
                foreach (Company company in results)
                {
                    searchResults.Items.Add(String.Format("{0} - {1}", company.Name, company.Symbol));
                }
            }
        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            int index = searchResults.SelectedIndex;
            Company company = results[index];
            tradeCompanyName.Text= company.Name;
            tradeSymbol.Text=company.Symbol;
            tradeStockPrice.Text=company.getStockPrice().ToString();
            tradeExchange.Text = stock.getExchange(company.Symbol);
            tradeIPO.Text = company.IPOyear;
        }

        private void searchEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(null, null);
                e.Handled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
