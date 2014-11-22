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
    public partial class MainForm : Form
    {
        User user;
        List<Company> results = new List<Company>();
        public MainForm()
        {
            InitializeComponent();
            showLogin();
            updateMarketStatus();
            initializeUser();
        }

        public void updateMarketStatus()
        {
            Stock marketCheck = new Stock();
            if (marketCheck.IsOpenStockMarket())
            {
                marketStatus.Text = "Open";
                marketStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                marketStatus.Text = "Closed";
                marketStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void setUser(string uName)
        {
            
        }

        public void showLogin()
        {
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Environment.Exit(0);
                return;
            }
            user = LoginController.Login(login.getUsername(), login.getPassword());
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                showLogin();
            }
        }

        public void initializeUser()
        {
            statusUserCash.Text = user.Cash.ToString("C2");
            statusUsername.Text = user.Username;
            updateOverview();
        }

        public void updateOverview()
        {
            NetWorthLabel.Text = user.Worth.ToString("C2");
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
                if (user.Cash < (company.getStockPrice() * numOfShares))
                {
                    MessageBox.Show("You don't have enough money!!");
                }
                else
                {
                    DateTime now = DateTime.Now;
                    user.BuyStock(company.Name, company.Symbol, company.getStockPrice(), numOfShares, now);
                    statusUserCash.Text = user.Cash.ToString("C2");
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
            portDataGrid.Rows.Clear();
            portDataGrid.Refresh();
            portDataGrid.ColumnCount = 7;
            portDataGrid.Columns[0].Name = "Company Name";
            portDataGrid.Columns[1].Name = "Company Symbol";
            portDataGrid.Columns[2].Name = "Number of Shares";
            portDataGrid.Columns[3].Name = "Current Price";
            portDataGrid.Columns[4].Name = "Worth";
            portDataGrid.Columns[5].Name = "Total Invested";

            List<Holding> stocks = user.Holdings;
            //loop through the purchased stocks.
            foreach (Holding stock in stocks)
            {
                string[] row = new string[6];
                row[0] = stock.companyName;
                row[1] = stock.stockSymbol;
                row[2] = stock.numOfShares.ToString();
                row[3] = stock.currentSharePrice.ToString("C2");
                row[4] = stock.worth.ToString("C2");
                row[5] = stock.totalInvested.ToString("C2");
                portDataGrid.Rows.Add(row);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tradeSellButton_Click(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            if (index > -1)
            {
                Company company = results[index];
                int numOfShares = 0;
                numOfShares = Convert.ToInt32(tradeNumOfShares.Text);
                DateTime now = DateTime.Now;
                double price = company.getStockPrice();
                if (user.SellStock(company.Name, company.Symbol, price, numOfShares, now))
                {
                    MessageBox.Show("You sold " + numOfShares.ToString() + " share(s) of " + company.Name + " at " + price.ToString("C2") +" a share.");
                }
                else
                {
                    MessageBox.Show("Not enough shares owned.");
                }
                statusUserCash.Text = user.Cash.ToString("C2");
            }
            else
            {
                MessageBox.Show("No company selected!!1!");
            }
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            if (index > -1)
            {
                Company company = results[index];
                user.AddToWatchList(company);
            }
            else
            {
                MessageBox.Show("No company selected.");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(user);
            settings.ShowDialog();
            user=settings.getUser();
            statusUserCash.Text = user.Cash.ToString("C2");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LoginController.Logout(user);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
    }
}
