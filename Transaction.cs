using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{ 
    class UserProfile
    {
        private List<CompanyStock> lCompanyStock;
        private List<StockTransaction> lStockTransaction;

        private string sName;

        private double dMoney;
        private double dPurchases;
        private double dSales;
        private double dChargedFees;
        private double dTransFee;

        public  UserProfile()
        {
            sName = "default";
            dMoney = 5000.0;
            dPurchases = 0.0;
            dSales = 0.0;
            dChargedFees = 0.0;
            dTransFee = 7.00;

            lCompanyStock = new List<CompanyStock>();
            lStockTransaction = new List<StockTransaction>();
        }
        public  UserProfile(string name)
        {
           //loading constructor.
           //loads user data from file.
        }

        public bool BuyStock(String name, string symbol, double price, double shares, DateTime dt)
        {
            if (shares * price > dMoney)
                return false;

            bool found = false;

            lStockTransaction.Add(new StockTransaction(name, symbol, price, shares, dt, false));

            for (int i = 0; i < lCompanyStock.Count && !found; i++)
            {
                if (lCompanyStock[i].GetName() == name && lCompanyStock[i].GetSymbol() == symbol)
                {
                    double spentTemp = lCompanyStock[i].GetSpent();
                    double sharesTemp = lCompanyStock[i].GetShares();
                    found = true;
                    lCompanyStock[i].SetShares(sharesTemp + shares);
                    lCompanyStock[i].SetSpent(spentTemp + (price * shares));
                }
            }
            if (!found)
            {
                lCompanyStock.Add(new CompanyStock(name, symbol, price * shares, 0, shares));
            }

            return true;
        }

        public bool SellStock(String name, string symbol, double price, double shares, DateTime dt)
        {
            bool found = false;
            for (int i = 0; i < lCompanyStock.Count && !found; i++)
            {
                if (lCompanyStock[i].GetName() == name && lCompanyStock[i].GetSymbol() == symbol)
                {
                    double  earnedTemp = lCompanyStock[i].GetEarned();
                    double  sharesTemp = lCompanyStock[i].GetShares();
                    found = true;
                    if (shares > sharesTemp)
                        return false;
                    lCompanyStock[i].SetEarned(earnedTemp+(shares*price));
                    lCompanyStock[i].SetShares(sharesTemp - shares);

                }
            }
            lStockTransaction.Add(new StockTransaction(name, symbol, price, shares, dt, true));
            return true;
        }

        public UserProfile(string name, double money, double transFee)
        {
            //setting up a new user
            sName = name;
            if (!SetMoney(money))
            {
                dMoney = 0.0;
            }
            dPurchases = 0.0;
            dSales = 0.0;
            dChargedFees = 0.0;
            dTransFee = transFee;
        }

        public double GetMoney()
        {
            return dMoney;
        }

        bool SetMoney(double money)
        {
            if (money >= 0.0)
            {
                dMoney = money;
                return true;
            }
            return false;
        }

        public double GetPurchases()
        {
            return dPurchases;
        }

        public bool SetPurchases(double pur)
        {
            if (pur >= 0)
            {
                dPurchases = 0.0;
                return true;
            }
            return false;
        }

        public double GetSales()
        {
            return dSales;
        }

        public bool SetSales(double sales)
        {
            if (sales >= 0)
            {
                dSales = sales;
                return true;
            }
            return false;
        }

        public double GetChargedFee()
        {
            return dTransFee;
        }

        public bool SetChargedFee(double charged)
        {
            if (charged >= 0.0)
            {
                dChargedFees = charged;
                return true;
            }
            return false;
        }

        public double GetTransActionFee()
        {
            return dTransFee;
        }

        public bool SetTransActionFee(double transFee)
        {
            if (transFee >= 0)
            {
                dTransFee = transFee;
                return true;
            }
            return false;
        }
    }
}