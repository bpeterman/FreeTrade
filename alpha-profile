using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace profileSample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PurchasedStock
    {
        private string sName, sSymbol;
        float fPurchasePrice, fNumOfShares,fInitialNumOfShares; // some companies deal in partial shares.
        DateTime dtPurchaseDate;

        public PurchasedStock(string name, string symbol, float purPrice, float numOfShares, float initialNumOfShares, DateTime dt)
        {
            sName = name;
            sSymbol = symbol;
            fPurchasePrice = purPrice;
            fNumOfShares = numOfShares;
            fInitialNumOfShares = initialNumOfShares;
           
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            dtPurchaseDate = new DateTime(year, month, day, hour, minute, second); // no messing with our guts
            //no one should have a reference to our internal parts of our class
        }

        string getName()
        {
            return sName;
        }

        bool setName(string n)
        {
            if (n.Length > 0)
            {
                sName = n;
                return true;
            }
            return false;
        }

        string GetSymbol()
        {
            return sSymbol;
        }

        bool SetSymbol(String s)
        {
            if (s.Length > 0)
            {
                sSymbol = s;
                return true;
            }
            return false;
        }

        float getInitalNumOfShares()
        {
            return fInitialNumOfShares;
        }

        bool setInitalNumOfShares(float ins)
        {
            if (ins > 0)
            {
                fInitialNumOfShares = ins;
                return true;
            }
            return false;
        }

        float getNumOfShare()
        {
            return fNumOfShares;
        }
        bool setNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares = ns; 
                return true;
            }
            return false;
        }

        bool removeNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares -= ns;
                return true;
            }
            return false;
        }

        float GetPrice()
        {
            return fPurchasePrice;
        }

        bool SetPurchasePrice(float p)
        {
            if (p >= 0)
            {
                fPurchasePrice = p;
                return true;
            }
            return false;
        }

        DateTime GetPurchaseDate()
        {
            int year = dtPurchaseDate.Year;
            int month = dtPurchaseDate.Month;
            int day = dtPurchaseDate.Day;
            int hour = dtPurchaseDate.Hour;
            int minute = dtPurchaseDate.Minute;
            int second = dtPurchaseDate.Second;

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        void SetPurchaseDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            dtPurchaseDate = new DateTime(year, month, day, hour, minute, second);
        }
    }
    public class SoldStock
    {
        private string sName, sSymbol;
        float fPurchasePrice, fNumOfShares; // some companies deal in partial shares.
        DateTime dtPurDate, dtSoldDate;

        public SoldStock(string name, string symbol, float purPrice, float numOfShares, float initialNumOfShares, DateTime purDate, DateTime soldDate)
        {
            sName = name;
            sSymbol = symbol;
            fPurchasePrice = purPrice;
            fNumOfShares = numOfShares;
           
            int year = purDate.Year;
            int month = purDate.Month;
            int day = purDate.Day;
            int hour = purDate.Hour;
            int minute = purDate.Minute;
            int second = purDate.Second;
            dtPurDate = new DateTime(year, month, day, hour, minute, second); // no messing with our guts
            //no one should have a reference to our internal parts of our class
            
            year = soldDate.Year;
            month = soldDate.Month;
            day = soldDate.Day;
            hour = soldDate.Hour;
            minute = soldDate.Minute;
            second = soldDate.Second;
            dtSoldDate = new DateTime(year, month, day, hour, minute, second);
        }

        string getName()
        {
            return sName;
        }

        bool setName(string n)
        {
            if (n.Length > 0)
            {
                sName = n;
                return true;
            }
            return false;
        }

        string GetSymbol()
        {
            return sSymbol;
        }

        bool SetSymbol(String s)
        {
            if (s.Length > 0)
            {
                sSymbol = s;
                return true;
            }
            return false;
        }
    
        float getNumOfShare()
        {
            return fNumOfShares;
        }

        bool setNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares = ns;
                return true;
            }
            return false;
        }

        bool removeNumOfShares(float ns)
        {
            if (ns > 0 && ns <= fNumOfShares)
            {
                fNumOfShares -= ns;
                return true;
            }
            return false;
        }



        float GetPrice()
        {
            return fPurchasePrice;
        }

        bool SetPurchasePrice(float p)
        {
            if (p >= 0)
            {
                fPurchasePrice = p;
                return true;
            }
            return false;
        }

        DateTime GetPurchaseDate()
        {
            int year = dtPurDate.Year;
            int month = dtPurDate.Month;
            int day = dtPurDate.Day;
            int hour = dtPurDate.Hour;
            int minute = dtPurDate.Minute;
            int second = dtPurDate.Second;

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        void SetPurchaseDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            dtPurDate = new DateTime(year, month, day, hour, minute, second);
        }
        DateTime GetSoldDate()
        {
            int year = dtSoldDate.Year;
            int month = dtSoldDate.Month;
            int day = dtSoldDate.Day;
            int hour = dtSoldDate.Hour;
            int minute = dtSoldDate.Minute;
            int second = dtSoldDate.Second;

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        void SetSoldDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            dtSoldDate = new DateTime(year, month, day, hour, minute, second);
        }
    }
}
