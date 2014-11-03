//brandon


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
            UserProfile up = new UserProfile();
            DateTime temp = DateTime.Now;
            int year = temp.Year;
            int month = temp.Month;
            int day = temp.Day;
            int hour = temp.Hour;
            int minute = temp.Minute;
            int second = temp.Second;
            temp = new DateTime(year, month, day, hour, minute, second);



            Console.WriteLine("money {0}", up.GetMoney());
            up.PurchaseStock(new PurchasedStock("bubba", "Bu", 20.00, 12, 12, temp));
            // public PurchasedStock(string name, string symbol, double purPrice, float numOfShares, float initialNumOfShares, DateTime dt) 
            
            Console.WriteLine("money {0}",up.GetMoney());
            up.SellStock("bubba", "bu", temp, DateTime.Now, 10, 28.50);
            Console.WriteLine("money {0}", up.GetMoney());
        }

    }

    class UserProfile
    {
        private string sName;
        private double dMoney;
        List<PurchasedStock> lPurchasedStocks;
        List<SoldStock> lSoldStocks;

        public UserProfile()
        {
            sName = "default";
            dMoney = 5000.00;
            lPurchasedStocks = new List<PurchasedStock>();
            lSoldStocks = new List<SoldStock>();
        }

        public UserProfile(string name, double money)
        {
            sName = name;
            dMoney = money;
            lPurchasedStocks = new List<PurchasedStock>();
            lSoldStocks = new List<SoldStock>();
        }

        public double GetMoney()
        {
           return dMoney;
        }

        public bool SetMoney(double m)
        {
            if (m >= 0)
            {
                dMoney = m;
                return true;
            }
            return false;
        }

        public bool PurchaseStock(PurchasedStock ps)
        {
            if (dMoney >= ps.GetPrice())
            {
                lPurchasedStocks.Add(new PurchasedStock(ps.GetName(), ps.GetSymbol(), ps.GetPrice(), ps.GetNumOfShares(), ps.GetInitalNumOfShares(), ps.GetPurchaseDate()));
                dMoney -= (ps.GetPrice()*ps.GetInitalNumOfShares());
                return true;
            }
            return false;
        }

        public bool SellStock(string stockName, string stockSymbol, DateTime purchasedDate, DateTime saleDate, float numOfShare, double salePrice)
        {

            bool bFound = false;
            for (int i = 0; i < lPurchasedStocks.Count && !bFound; i++)
            {
                if (string.Compare(lPurchasedStocks[i].GetSymbol(), stockSymbol, true) == 0 && lPurchasedStocks[i].GetPurchaseDate().Equals(purchasedDate))
                {
                    if (lPurchasedStocks[i].GetNumOfShares() >= numOfShare)
                    {
                        lSoldStocks.Add(new SoldStock(stockName, stockSymbol, lPurchasedStocks[i].GetPrice(), numOfShare, salePrice, lPurchasedStocks[i].GetPurchaseDate(), saleDate));

                        bFound = true;
                        if (lPurchasedStocks[i].GetNumOfShares() - numOfShare == 0)
                        {
                            lPurchasedStocks.RemoveAt(i);

                        }
                        else
                        {
                            float temp = lPurchasedStocks[i].GetNumOfShares();
                            lPurchasedStocks[i].SetNumOfShares(temp - numOfShare);
                        }
                        dMoney += (numOfShare * salePrice);
                    }

                }
            }


            return bFound;
        }

    }

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
            dtPurchaseDate = new DateTime(year, month, day, hour, minute, second); // no messing with our guts
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

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        public void SetPurchaseDate(DateTime dt)
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

        public float GetNumOfShare()
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

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        public void SetPurchaseDate(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            dtPurDate = new DateTime(year, month, day, hour, minute, second);
        }

        public DateTime GetSoldDate()
        {
            int year = dtSoldDate.Year;
            int month = dtSoldDate.Month;
            int day = dtSoldDate.Day;
            int hour = dtSoldDate.Hour;
            int minute = dtSoldDate.Minute;
            int second = dtSoldDate.Second;

            return new DateTime(year, month, day, hour, minute, second); // we do not want our interal guts exposed.
        }

        public void SetSoldDate(DateTime dt)
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
