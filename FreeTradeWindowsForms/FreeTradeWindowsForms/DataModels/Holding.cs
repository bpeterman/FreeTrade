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
            this.numOfShares = 0;
            this.totalInvested = 0;
            this.worth = 0;
        }

        public int numOfShares;
        public string stockSymbol;
        public double totalInvested;
        public double worth;

        public void Refresh(double currentPrice)
        {
            worth = numOfShares * currentPrice;
        }
    }
}
