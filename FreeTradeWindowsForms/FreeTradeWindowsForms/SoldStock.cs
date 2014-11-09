using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeTradeWindowsForms
{
    public class SoldStock
    {
        private string sName, sSymbol;

        float fNumOfShares; // some companies deal in partial shares.

        double dPurchasePrice;
        double dSoldPrice;

        DateTime dtPurDate, dtSoldDate;

        public SoldStock(string name, string symbol, double purPrice, float numOfShares, double soldPrice, DateTime purDate, DateTime soldDate)
        {
            sName = name;
            sSymbol = symbol;
            dPurchasePrice = purPrice;
            fNumOfShares = numOfShares;
            dSoldPrice = soldPrice;

            int year = purDate.Year;
            int month = purDate.Month;
            int day = purDate.Day;
            int hour = purDate.Hour;
            int minute = purDate.Minute;
            int second = purDate.Second;
            int millisecond = purDate.Millisecond;
            dtPurDate = new DateTime(year, month, day, hour, minute, second, millisecond); // no messing with our guts
            //no one should have a reference to our internal parts of our class

            year = soldDate.Year;
            month = soldDate.Month;
            day = soldDate.Day;
            hour = soldDate.Hour;
            minute = soldDate.Minute;
            second = soldDate.Second;
            millisecond = soldDate.Millisecond;
            dtSoldDate = new DateTime(year, month, day, hour, minute, second, millisecond);
        }

        public string GetName()
        {
            return sName;
        }

        public bool SetName(string n)
        {
            if (n.Length > 0)
            {
                sName = n;
                return true;
            }
            return false;
        }

        public string GetSymbol()
        {
            return sSymbol;
        }

        public bool SetSymbol(String s)
        {
            if (s.Length > 0)
            {
                sSymbol = s;
                return true;
            }
            return false;
        }

        public float GetNumOfShares()
        {
            return fNumOfShares;
        }

        public bool SetNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares = ns;
                return true;
            }
            return false;
        }

        public bool RemoveNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares -= ns;
                return true;
            }
            return false;
        }



        public double GetPrice()
        {
            return dPurchasePrice;
        }

        public double GetSoldPrice()
        {
            return dSoldPrice;
        }

        public bool setSoldprice(double sp)
        {
            if (sp >= 0)
            {
                dSoldPrice = sp;
                return true;
            }
            return false;
        }

        public bool SetPurchasePrice(double p)
        {
            if (p >= 0)
            {
                dPurchasePrice = p;
                return true;
            }
            return false;
        }

        public DateTime GetPurchaseDate()
        {
            int year = dtPurDate.Year;
            int month = dtPurDate.Month;
            int day = dtPurDate.Day;
            int hour = dtPurDate.Hour;
            int minute = dtPurDate.Minute;
            int second = dtPurDate.Second;
            int millisecond = dtPurDate.Millisecond;

            return new DateTime(year, month, day, hour, minute, second, millisecond); // we do not want our interal guts exposed.
        }

        public void SetPurchaseDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            int millisecond = dt.Millisecond;

            dtPurDate = new DateTime(year, month, day, hour, minute, second, millisecond);
        }

        public DateTime GetSoldDate()
        {
            int year = dtSoldDate.Year;
            int month = dtSoldDate.Month;
            int day = dtSoldDate.Day;
            int hour = dtSoldDate.Hour;
            int minute = dtSoldDate.Minute;
            int second = dtSoldDate.Second;
            int millisecond = dtSoldDate.Millisecond;
            return new DateTime(year, month, day, hour, minute, second, millisecond); // we do not want our interal guts exposed.
        }

        public void SetSoldDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            int millisecond = dtSoldDate.Millisecond;
            dtSoldDate = new DateTime(year, month, day, hour, minute, second, millisecond);
        }
    }
}
