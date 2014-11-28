using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeTradeWindowsForms.Controllers;
using FreeTradeWindowsForms.Models;
using System.Threading;

namespace FreeTradeWindowsForms
{
    public partial class MainForm : Form
    {
        User user;
        List<Company> results = new List<Company>();
        Thread refreshThread;
        System.Timers.Timer refreshTimer;
        public MainForm()
        {
            InitializeComponent();
            showLogin();
            updateMarketStatus();
            initializeUser();
            refreshThread = new Thread(refresh);
            refreshThread.Start();
            refreshTimer = new System.Timers.Timer(30000);
        }

        public void refresh()
        {
            Thread.Sleep(30000);
            this.Invoke((MethodInvoker)delegate
            {
                if (mainTab.SelectedIndex == 0)
                {
                    user.refresh();
                    updateOverview();
                }
            });
            refresh();
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
            LabelCashOverview.Text = user.Worth.ToString("C2");
            updateWatchlistBox();
            UpdateTopGainersListbox();
            LabelOverallWorth.Text = user.Worth.ToString("C2");
            double userTotalReturns = ((user.Worth / user.borrowedCash) - 1);
            LabelTotalReturns.Text = userTotalReturns.ToString("P");
            if (userTotalReturns < 0)
                LabelTotalReturns.ForeColor = Color.Red;
            else
                LabelTotalReturns.ForeColor = Color.Green;
            LabelCashOverview.Text = user.Cash.ToString("C2");
        }

        private void updateWatchlistBox()
        {
            ListBoxWatchlist.Items.Clear();
            List<Company> comps = user.WatchList;
            comps.Reverse();
            foreach (Company company in comps)
            {
                ListBoxWatchlist.Items.Add(String.Format("{0} - {1}", company.Name, company.getStockPrice().ToString("C2")));
            }
        }

        private void UpdateTopGainersListbox()
        {
            ListBoxTop5Gains.Items.Clear();
            ListBoxTop5Loss.Items.Clear();
            List<Holding> topGainers = user.GetTopGainers(5, true);
            foreach (Holding holding in topGainers)
                ListBoxTop5Gains.Items.Add(String.Format("{0} | %{1}", holding.companyName, holding.GetPerformance().ToString("P"))); 
            topGainers = user.GetTopGainers(5, false);
            foreach (Holding holding in topGainers)
                ListBoxTop5Loss.Items.Add(String.Format("{0} | %{1}", holding.companyName, holding.GetPerformance().ToString("P")));
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
            if (index >= 0)
            {
                Company company = results[index];
                tradeCompanyName.Text = company.Name;
                tradeSymbol.Text = company.Symbol;
                tradeStockPrice.Text = company.getStockPrice().ToString("C2");
                tradeExchange.Text = stock.getExchange(company.Symbol);
                tradeIPO.Text = company.IPOyear;
                tradeIndustry.Text = company.Industry;
                tradeHigh.Text = stock.getStockYearHigh(company.Symbol).ToString("C2");
                tradeLow.Text = stock.getStockYearLow(company.Symbol).ToString("C2");

                List<Holding> holdings = user.Holdings;
                //loop through the purchased stocks.
                foreach (Holding holding in holdings)
                {
                    if (holding.stockSymbol.Equals(company.Symbol))
                    {
                        tradeCurrentSharesBox.Text = holding.numOfShares.ToString();
                        break;
                    }
                    else
                    {
                        tradeCurrentSharesBox.Text = "0";
                    }
                }
            }

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

                bool bParse = int.TryParse(tradeNumOfShares.Text, out numOfShares);
                
                DateTime now = DateTime.Now;
                
                // had to use short circuiting to make sure stocks were not bought with an ammount of zero. //rework of code??
                if (bParse && numOfShares > 0 && user.BuyStock(company.Name, company.Symbol, company.getStockPrice(), numOfShares, now))
                {
                    statusUserCash.Text = user.Cash.ToString("C2");

                    tradeCurrentSharesBox.Text = (Convert.ToDouble(tradeCurrentSharesBox.Text) + numOfShares).ToString();
                }
                else
                {
                    if(numOfShares < 1)
                         MessageBox.Show("Invalid Data in number of stocks.");
                }
            }
            else
            {
                MessageBox.Show("No company selected or field is empty!!!");
            }
        }

        private void tradeNumOfShares_TextChanged(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            if (index > -1 && tradeNumOfShares.Text.Length>0)
            {
                Company company = results[index];
               
                 int numOfShares = 0;
                 bool bParseSucces = false;

                bParseSucces = int.TryParse(tradeNumOfShares.Text, out numOfShares);

                if (bParseSucces)
                {
                
                    transAmBox.Text = (company.getStockPrice() * numOfShares).ToString("C2");
                }
             
                else
                {
                    MessageBox.Show("Non-Numerial Entry in Number of Share", "Invalid Input");
                    tradeNumOfShares.Text = "";
                }
            }
            else if (tradeNumOfShares.Text.Length == 0) 
            {
               
            }
            else
            {
                MessageBox.Show("No company selected!!!!");
            }

        }

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTab.SelectedIndex == 0)
                updateOverview();
            if (mainTab.SelectedIndex == 1)
                fill_Portfolio();
            if (mainTab.SelectedIndex == 2)
                clearTrade(); 
            else
                clearTrade();
            if (mainTab.SelectedIndex == 3)
                updatePerformance(); 
        }

        public void clearTrade()
        {
            searchBox.Text = "";
            tradeCurrentSharesBox.Text = "";
            tradeCompanyName.Text = "";
            tradeSymbol.Text = "";
            tradeStockPrice.Text = "";
            tradeExchange.Text = "";
            tradeIPO.Text = "";
            tradeIndustry.Text = "";
            tradeHigh.Text = "";
            tradeLow.Text = "";
            tradeNumOfShares.Text = "";
            transAmBox.Text = "";
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
                bool bParse = int.TryParse(tradeNumOfShares.Text, out numOfShares);
                DateTime now = DateTime.Now;
                double price = company.getStockPrice();

                //had to use short circuiting 
                if (bParse && numOfShares > 0 && user.SellStock(company.Name, company.Symbol, price, numOfShares, now))
                {
                    tradeCurrentSharesBox.Text = (Convert.ToDouble(tradeCurrentSharesBox.Text) - numOfShares).ToString();
                }
                else
                    MessageBox.Show("Error in Number of stocks.");
                statusUserCash.Text = user.Cash.ToString("C2");
               
            }
                
            else
            {
                MessageBox.Show("No company selected!!!");
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
            refreshThread.Abort();
            base.OnFormClosing(e);
            LoginController.Logout(user);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }

        public void updatePerformance()
        {
            performanceHoldingsBox.Items.Clear();
            List<Holding> holdings = user.Holdings;
            //loop through the purchased stocks.
            foreach (Holding holding in holdings)
            {
                performanceHoldingsBox.Items.Add(String.Format("{0} | {1} | {2}", holding.companyName, holding.currentSharePrice.ToString("C2"), holding.GetPerformance().ToString("P")));
            }

            //load initial graph.
            updatePerformanceGraph("", "");
        }

        public void updatePerformanceGraph(string symbol, string timePeriod)
        {
            performancePic.Load("http://chart.finance.yahoo.com/z?s=" + symbol + "&t="+timePeriod);
        }

        private void performanceHoldingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePerformanceGraph(getHoldingBoxString(), getTimeBoxString());
        }
        private string getHoldingBoxString()
        {
            int i = performanceHoldingsBox.SelectedIndex;
            if (i < 0)
                return "";
            List<Holding> holdings = user.Holdings;
            return holdings[i].stockSymbol;
        }

        private void performanceTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePerformanceGraph(getHoldingBoxString(), getTimeBoxString());
        }
        private string getTimeBoxString()
        {
            int i = performanceTimeBox.SelectedIndex;
            if (i == 0)
                return "1d";
            else if (i == 1)
                return "5d";
            else if (i == 2)
                return "3m";
            else if (i == 3)
                return "6m";
            else if (i == 4)
                return "1y";
            else if (i == 5)
                return "2y";
            else if (i == 6)
                return "5y";
            else if (i == 7)
                return "my";
            else
                return "";
        }

        private void whatIfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhatIf whatIf = new WhatIf();
            whatIf.Show();
        }

        private void ButtonWatchlistDelete_Click(object sender, EventArgs e)
        {
            user.WatchList.RemoveAt(ListBoxWatchlist.SelectedIndex);
            ListBoxWatchlist.Items.RemoveAt(ListBoxWatchlist.SelectedIndex);
        }
    }
}
