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
        public Company(String symbol, String name, String sector, String industry, String ipoYear)
        {
            Symbol = symbol;
            Name = name;
            Sector = sector;
            Industry = industry;
            IPOyear = ipoYear;
        }

        public override string ToString()
        {
            return Name + " - " + Symbol;
        }
    }
}
