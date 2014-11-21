using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeTradeWindowsForms.Models
{
    public class Transaction
    {
        public string CompanyName { get; set; }
        public string StockSymbol { get; set; }
        public double SharePrice { get; set; }
        public int NumOfShares { get; set; }
        public DateTime date { get; set; }
        
        public Transaction()
        {

        }

        public Transaction(string companyName, string companySymbol, double sharePrice, int numOhShares, DateTime date)
        {
            this.CompanyName = companyName;
            this.StockSymbol = companySymbol;
            this.SharePrice = sharePrice;
            this.NumOfShares = numOhShares;
            this.date = date;
        }
    }
}
