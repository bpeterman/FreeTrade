using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class StockTransaction
    {
        private string sName;
        private string sStockSymbol;
        private double dPrice;
        private double dShares;
        private DateTime dtDate;

        public StockTransaction()
        {
            sName = "default";
            sStockSymbol = "dt";
            dPrice = 0.0;
            dShares = 0.0;
            dtDate = DateTime.Now;
        }

        public StockTransaction(string name, string symbol, double price, double shares, DateTime dt)
        {
            if (!SetName(name))//if Error.
            {
                sName = "Invalid Name";
            }
            if (!SetSymbol(symbol))
            {
                sStockSymbol = "Invalid Symbol";
            }

            if(!SetPrice(price))
            {
               price = 0.0;
            }
            
            if(!SetShares(shares))
            {
               dShares = 0.0;
            }
            SetDate(dtDate);
        }

        public string GetName()
        {
            return sName;
        }

        public bool SetName(string name)
        {
            if (sName.Length > 0)
            {
                sName = name;
                return true;
            }
            return false;
        }

        public string GetSymbol()
        {
            return sStockSymbol;
        }

        public bool SetSymbol(string symbol)
        {
            if (symbol.Length > 0)
            {
                sStockSymbol = symbol;
                return true;
            }
            return false;
        }

        public double GetPrice()
        {
            return dPrice;
        }

        public bool SetPrice(double price)
        {
            if (price >= 0.0)
            {
                dPrice = price;
                return true;
            }
            return false;
        }

        public double GetShares()
        {
            return dShares;
        }


        bool SetShares(double shares)
        {
            if (shares >= 0.0)
            {
                dShares = shares;
                return true;
            }
            return false;
        }


        public void SetDate(DateTime dt)
        {
            //creating a deep copy
            int Month = dt.Month;
            int Day = dt.Day;
            int Year = dt.Year;
            int Hour = dt.Hour;
            int Minute = dt.Minute;
            int Second = dt.Second;
            int Millisecond = dt.Millisecond;
            //deep copy  dont touch our guts.
            dtDate = new DateTime(Year, Month, Day, Hour, Minute, Second, Millisecond);
        
        }

        public DateTime GetDate()
        {
            //deep copy so others don't mess with the guts of the object.
            int Month = dtDate.Month;
            int Day = dtDate.Day;
            int Year = dtDate.Year;
            int Hour = dtDate.Hour;
            int Minute = dtDate.Minute;
            int Second = dtDate.Second;
            int Millisecond = dtDate.Millisecond;
            return new DateTime(Year, Month, Day, Hour, Minute, Second, Millisecond);
        
        }

    }
}
