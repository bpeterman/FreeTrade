using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeTradeWindowsForms.Models
{
    class Holding
    {
        /*
         * This class represents a company that a user is invested in.
         *  
         * Properties:
         *      numOfShares - the total number of shares invested in the company.
         *      stockSymbol - the stock symbol of the company that is being held.
         *      totalValue  - value of all assets in company
         *      worth       - the amount of money the holding is worth at the current stock price.
         * 
         */
        public Holding(string stockSymbol)
        {
            this.stockSymbol = stockSymbol;
        }

        public int numOfShares;
        public string stockSymbol;
        public double totalInvested;
        public double worth;
        public double currentSharePrice;

        public bool Sell(int numOfSharesToSell)
        {
            if (numOfSharesToSell > numOfShares)
            {
                return false;
            }

            numOfShares -= numOfSharesToSell;

            // Sale amount is subtracted from worth because worth is represents the overall worth of the stocks.
            double saleAmount = (numOfSharesToSell * GetCurrentPrice());
            worth -= saleAmount;

            // The effective price per share is the total amount of money invested divided by the number of shares being held.
            double effectivePricePerShare = (totalInvested / numOfShares);
            totalInvested -= (effectivePricePerShare * numOfSharesToSell);
        }

        public double GetPerformance()
        {
            return worth - totalInvested;
        }

        public void Update()
        {
            // Update total worth and currentSharPrice
        }
    }
}
