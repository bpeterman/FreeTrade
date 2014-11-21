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

        // Create a new user by setting the username, password, and how much cash they initially borrowed
        public User(string username, string password, double borrowedCash)
        {
            this.Username = username;
            this.Password = password;
            this.borrowedCash = borrowedCash;
            this.Worth = borrowedCash;
            this.Cash = borrowedCash;
            Holdings = new List<Holding>();
            Transactions = new List<Transaction>();
            WatchList = new List<Company>();
        }

        public User()
        {

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
            if (numOfShares * currentSharePrice > Cash)
                return false;

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

            MessageBox.Show("You just purchased " + numOfShares + " shares of " + companyName + " stock @ $" + currentSharePrice + " per share.");
            Cash = Cash - transactionAmount;
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

            if (holding == null)
                return false;

            if (numOfShares > holding.numOfShares)
                return false;

            holding.numOfShares = holding.numOfShares -  numOfShares;

            // Sale amount is subtracted from worth because worth is represents the overall worth of the stocks.
            double saleAmount = (numOfShares * currentSharePrice);
            holding.worth = holding.worth - saleAmount;
            Cash = Cash + saleAmount;

            // The effective price per share is the total amount of money invested divided by the number of shares being held.
            double effectivePricePerShare = (holding.totalInvested / holding.numOfShares);
            holding.totalInvested = holding.totalInvested - (effectivePricePerShare * numOfShares);
            refresh();
            return true;
        }

        /// <summary>
        /// Add a company to the user's watchlist.
        /// </summary>
        /// <param name="company"></param>
        public void AddToWatchList(Company company)
        {
            WatchList.Add(company);
        }

        /// <summary>
        /// Refresh user profile
        /// </summary>
        public void refresh()
        {
            // refresh everything in the user profile
            // refresh everything in each holding
            // 
            double tempWorth = 0;
            for (int i = 0; i < Holdings.Count; i++)
            {
                Holdings[i].Refresh(stock.getLatestValue(Holdings[i].stockSymbol));
                tempWorth += Holdings[i].worth;
            }
        }
    }
}
