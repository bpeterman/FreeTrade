using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeTradeWindowsForms;

namespace FreeTradeWindowsForms.Models
{
    
    public class User
    {
        Stock stock = new Stock();
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Buying power available
        /// </summary>
        public double Cash { get; set; }
        /// <summary>
        /// Overall worth of cash and all investments
        /// </summary>
        public double Worth { get; set; }
        /// <summary>
        /// Total amount of cash used for investing - this only changes if more cash is borrowed, this will be the basis of all performance calculations
        /// </summary>
        public double borrowedCash { get; set; }
        /// <summary>
        /// // All companies that are currently being invested in.
        /// </summary>
        public List<Holding> Holdings { get; set; } 

        public List<Transaction> Transactions { get; set; }

        public List<Company> WatchList { get; set; }

        /// <summary>
        /// This flag determines whether the user can trade when the market is closed
        /// </summary>
        public bool EnforceMarketClosure { get; set; }

        /// <summary>
        /// This value determines the fee that is charged for each transaction.
        /// </summary>
        public double transactionFee { get; set; }

        // Create a new user by setting the username, password, and how much cash they initially borrowed
        public User(string username, string password, double borrowedCash)
        {
            this.Username = username;
            this.Password = password;
            this.borrowedCash = borrowedCash;
            this.Worth = borrowedCash;
            this.Cash = borrowedCash;
            this.EnforceMarketClosure = true;
            this.transactionFee = 0;
            Holdings = new List<Holding>();
            Transactions = new List<Transaction>();
            WatchList = new List<Company>();
        }

        public User()
        {

        }


        /// <summary>
        /// Add more cash to use for investing. 
        /// </summary>
        /// <param name="amount"></param>
        public void AddCash(double amount)
        {
            Cash = Cash += amount;
            borrowedCash = borrowedCash += amount;
        }

        /// <summary>
        /// Buy stocks
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="companySymbol"></param>
        /// <param name="currentSharePrice"></param>
        /// <param name="numOfShares"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool BuyStock(string companyName, string companySymbol, double currentSharePrice, int numOfShares, DateTime time)
        {
            if (!stock.IsOpenStockMarket() && EnforceMarketClosure)
            {
                MessageBox.Show("The market is closed.");
                return false;
            }

            if (numOfShares * currentSharePrice > Cash)
            {
                MessageBox.Show("You don't have enough money for that purchase. Dummy.");
                return false;
            }

            double transactionAmount = (numOfShares * currentSharePrice);
            // create a new holding if one doesn't already exist
            Holding holding = GetHolding(companySymbol);
            if (holding == null)
            {
                holding = new Holding(companySymbol);
                Holdings.Add(holding);
                holding.companyName = companyName;
                holding.currentSharePrice = currentSharePrice;
            }
            holding.numOfShares += numOfShares;
            holding.totalInvested += (transactionAmount);
            holding.worth += (transactionAmount);

            // Add to list of transactions
            Transactions.Add(new Transaction(companyName, companySymbol, currentSharePrice, numOfShares, time));

            MessageBox.Show("You just purchased " + numOfShares + " shares of " + companyName + " stock at" + currentSharePrice.ToString("C2") + " per share.");
            Cash = Cash - transactionAmount;
            Cash = Cash - transactionFee;
            refresh();
            return true;
        }

        /// <summary>
        /// Get a holding information
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public Holding GetHolding(string companySymbol)
        {
            for (int i = 0; i < Holdings.Count; i++)
            {
                if (Holdings[i].stockSymbol == companySymbol)
                {
                    return Holdings[i];
                }
            }
            return null;
        }
        
        /// <summary>
        /// Sell stocks
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="companySymbol"></param>
        /// <param name="currentSharePrice"></param>
        /// <param name="numOfShares"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool SellStock(string companyName, string companySymbol, double currentSharePrice, int numOfShares, DateTime time)
        {
            Holding holding = GetHolding(companySymbol);

            if (!stock.IsOpenStockMarket() && EnforceMarketClosure)
            {
                MessageBox.Show("The market is closed.");
                return false;
            }
            if (holding == null)
                return false;

            if (numOfShares > holding.numOfShares)
            {
                MessageBox.Show("You cannot sell more shares than you own, dummy...");
                return false;
            }

            // Sale amount is subtracted from worth because worth is represents the overall worth of the stocks.
            double saleAmount = (numOfShares * currentSharePrice);
            holding.worth = holding.worth - saleAmount;
            Cash = Cash + saleAmount;
            Cash = Cash - transactionFee;

            // The effective price per share is the total amount of money invested divided by the number of shares being held.
            double effectivePricePerShare = (holding.totalInvested / holding.numOfShares);
            holding.totalInvested = holding.totalInvested - (effectivePricePerShare * numOfShares);

            holding.numOfShares = holding.numOfShares - numOfShares;
            refresh();
            MessageBox.Show("You sold " + numOfShares.ToString() + " share(s) of " + companyName + " at " + currentSharePrice.ToString("C2") + " a share. Total sale amount: " + saleAmount.ToString("C2"));
            return true;
        }

        /// <summary>
        /// Add a company to the user's watchlist.
        /// </summary>
        /// <param name="company"></param>
        public void AddToWatchList(Company company)
        {
            if (!CompanyInWatchList(company))
            {
                WatchList.Add(company);
                MessageBox.Show("Company added to watchlist.");

            }
            else
            {
                MessageBox.Show("Company already in watchlist.");
            }
        }

        public bool CompanyInWatchList(Company company)
        {
            foreach (Company watchListCompany in WatchList)
            {
                if (company.Symbol == watchListCompany.Symbol)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Refresh user profile
        /// </summary>
        public void refresh()
        {
            // refresh everything in the user profile
            // refresh everything in each holding
            double tempWorth = 0;
            for (int i = 0; i < Holdings.Count; i++)
            {
                Holdings[i].Refresh(stock.getLatestValue(Holdings[i].stockSymbol));
                tempWorth += Holdings[i].worth;
            }
            Worth = Cash + tempWorth;
        }

        /// <summary>
        /// Get a list of the top gainers
        /// </summary>
        /// <param name="count">How many holdings do you want in the list?</param>
        /// <param name="Gains">If true, returns top gainers, if false, top losers.</param>
        /// <returns></returns>
        public List<Holding> GetTopGainers(int count, bool gains)
        {
            refresh();
            List<Holding> topGainers; 
            if (gains)
                topGainers = Holdings.OrderByDescending(o => o.GetPerformance()).ToList();
            else
                topGainers = Holdings.OrderBy(o => o.GetPerformance()).ToList();

            if (count < Holdings.Count)
            {
                List<Holding> topGainersConstrained = new List<Holding>();
                for (int i = 0; i < count; i++)
                    topGainersConstrained.Add(topGainers[i]);
                return topGainersConstrained;
            }
            return topGainers;
        }

        private void AddTestDataToHoldings()
        {
            Holding holding = new Holding("AAPL");
            holding.numOfShares = 5;
            holding.totalInvested = 80.00;
            Holdings.Add(holding);

            holding = new Holding("TSLA");
            holding.numOfShares = 10;
            holding.totalInvested = 10000.00;
            Holdings.Add(holding);

        }
    }
}
