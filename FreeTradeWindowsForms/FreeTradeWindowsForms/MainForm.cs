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
        UserProfile user;
        List<Company> results = new List<Company>();
        public MainForm()
        {
            InitializeComponent();
            showLogin();
        }

        public void setUser(string uName)
        {
            user = new UserProfile(uName);
        }

        public void showLogin()
        {
            Login login = new Login();
            login.ShowDialog();
            initializeUser(login.getUsername());
        }

        public void initializeUser(string uName)
        {
            user = new UserProfile(uName);
            statusUserCash.Text = user.GetMoney().ToString("C2");
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
            tradeCompanyName.Text = company.Name;
            tradeSymbol.Text = company.Symbol;
            tradeStockPrice.Text = company.getStockPrice().ToString("C2");
            tradeExchange.Text = stock.getExchange(company.Symbol);
            tradeIPO.Text = company.IPOyear;
            tradeIndustry.Text = company.Industry;
            tradeHigh.Text = stock.getStockYearHigh(company.Symbol).ToString("C2");
            tradeLow.Text = stock.getStockYearLow(company.Symbol).ToString("C2");
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

        private void buyButton_Click(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            if (index > -1)
            {
                Company company = results[index];
                int numOfShares = 0;
                numOfShares = Convert.ToInt32(tradeNumOfShares.Text);
                if (user.GetMoney() < (company.getStockPrice() * numOfShares))
                {
                    MessageBox.Show("You don't have enough money!!");
                }
                else
                {
                    DateTime now = DateTime.Now;
                    PurchasedStock ps = new PurchasedStock(company.Name, company.Symbol, company.getStockPrice(), numOfShares, numOfShares, now);
                    user.PurchaseStock(ps);
                    statusUserCash.Text = user.GetMoney().ToString("C2");
                    user.WriteToFile();
                    MessageBox.Show("You purchased " + numOfShares + " shares of " + company.Name);
                }
            }
            else
            {
                MessageBox.Show("No company selected!!1!");
            }
        }

        private void tradeNumOfShares_TextChanged(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            if (index > -1 && tradeNumOfShares.Text.Length>0)
            {
                Company company = results[index];
                int numOfShares = 0;
                numOfShares = Convert.ToInt32(tradeNumOfShares.Text);
                transAmBox.Text=(company.getStockPrice()*numOfShares).ToString("C2");
            }
            else if (tradeNumOfShares.Text.Length == 0) 
            {
               
            }
            else
            {
                MessageBox.Show("No company selected!!1!");
            }

        }

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTab.SelectedIndex == 1)
                fill_Portfolio();
        }
        public void fill_Portfolio()
        {
            portDataGrid.ColumnCount = 7;
            portDataGrid.Columns[0].Name = "Company Name";
            portDataGrid.Columns[1].Name = "Company Symbol";
            portDataGrid.Columns[2].Name = "Number of Shares";
            portDataGrid.Columns[3].Name = "Purchase Price";
            portDataGrid.Columns[4].Name = "Purchase Date";

            
        }
    }
}
