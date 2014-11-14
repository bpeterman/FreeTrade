//made obsolete by transactioncs.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace profileSample
{
    public class PurchasedStock
    {
        private string sName, sSymbol;
        float fNumOfShares, fInitialNumOfShares; // some companies deal in partial shares.
        double dPurchasePrice;
        DateTime dtPurchaseDate;

        public PurchasedStock(string name, string symbol, double purPrice, float numOfShares, float initialNumOfShares, DateTime dt)
        {
            sName = name;
            sSymbol = symbol;
            dPurchasePrice = purPrice;
            fNumOfShares = numOfShares;
            fInitialNumOfShares = initialNumOfShares;

            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            int milisecond = dt.Millisecond;
            dtPurchaseDate = new DateTime(year, month, day, hour, minute, second, milisecond); // no messing with our guts
            //no one should have a reference to our internal parts of our class
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

        public float GetInitalNumOfShares()
        {
            return fInitialNumOfShares;
        }

        public bool SetInitalNumOfShares(float ins)
        {
            if (ins > 0)
            {
                fInitialNumOfShares = ins;
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
            int year = dtPurchaseDate.Year;
            int month = dtPurchaseDate.Month;
            int day = dtPurchaseDate.Day;
            int hour = dtPurchaseDate.Hour;
            int minute = dtPurchaseDate.Minute;
            int second = dtPurchaseDate.Second;
            int millisecond = dtPurchaseDate.Millisecond;

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
            int millisecond = dtPurchaseDate.Millisecond;
            dtPurchaseDate = new DateTime(year, month, day, hour, minute, second, millisecond);
        }
    }
}
