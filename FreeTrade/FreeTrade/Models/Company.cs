using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeTrade
{
    public class Company
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string IPOyear { get; set; }
        public double StockPrice;
        public Company(String symbol, String name, String sector, String industry, String ipoYear, double stockPrice)
        {
            Symbol = symbol;
            Name = name;
            Sector = sector;
            Industry = industry;
            IPOyear = ipoYear;
            StockPrice = stockPrice;
        }

        public double getStockPrice()
        {
            Stock stock = new Stock();
            return stock.getLatestValue(Symbol);
        }

        public override string ToString()
        {
            return Name + " - " + Symbol;
        }

        public bool Contains(string query)
        {
            query = query.ToLower();
            return (Symbol.ToLower().Contains(query) ||
                Name.ToLower().Contains(query) ||
                Sector.ToLower().Contains(query) ||
                Industry.ToLower().Contains(query) ||
                IPOyear.ToLower().Contains(query));
        }
    }
}
