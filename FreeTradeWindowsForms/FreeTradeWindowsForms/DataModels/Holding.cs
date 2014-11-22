using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeTradeWindowsForms.Models
{
    public class Holding
    {
        // TODO: add companyName and currentPrice
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
            this.companyName = "";
            this.currentSharePrice = 0.0;
            this.numOfShares = 0;
            this.totalInvested = 0.0;
            this.worth = 0.0;
            this.performance = 0.0;
        }

        public Holding()
        {

        }

        public int numOfShares;
        public string stockSymbol;
        public string companyName;
        public double totalInvested;
        public double currentSharePrice;
        public double worth;
        public double performance;


        /// <summary>
        /// Get the percentage increase or decrease, don't forget to update the current share price manually before using this.
        /// </summary>
        public double GetPerformance()
        {
            return ((worth / totalInvested) - 1);
        } 

        public void Refresh(double currentPrice)
        {
            this.currentSharePrice = currentPrice;
            worth = numOfShares * currentPrice;
        }
    }
}
