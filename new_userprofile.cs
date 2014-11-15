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

            if (!SetTransActionFee(transFee))
            {
                dTransFee = 2.00;
            }
            lCompanyStock = new List<CompanyStock>();
            lStockTransaction = new List<StockTransaction>();
        }


        public  UserProfile(string name)
        {
           //loading constructor.
           //loads user data from file.
            lCompanyStock = new List<CompanyStock>();
            lStockTransaction = new List<StockTransaction>();
        }

       

        public void WriteToFiles()
        { 
            //5 fields/
           string nl = Environment.NewLine;
           string temp = dMoney.ToString() + nl + dPurchases.ToString() + nl + dSales.ToString() + nl + dChargedFees.ToString() + nl + dTransFee.ToString();
           System.IO.File.WriteAllText(sName + "UserProfile.txt", temp);
          
           System.IO.StreamWriter file = new System.IO.StreamWriter(sName + "CompanyStock.txt", true);
           
           foreach(CompanyStock cs in lCompanyStock)
           {  //5 fields
               file.WriteLine(cs.GetName());
               file.WriteLine(cs.GetSymbol());
               file.WriteLine(cs.GetSpent().ToString());
               file.WriteLine(cs.GetEarned().ToString());
               file.WriteLine(cs.GetShares().ToString());
           }
           file.Close();

           file = new System.IO.StreamWriter(sName + "StockTransaction.txt", true);

           foreach(StockTransaction st in lStockTransaction)
           {   //6 lines
               file.WriteLine(st.GetName());
               file.WriteLine(st.GetSymbol());
               file.WriteLine(st.GetPrice());
               file.WriteLine(st.GetShares());
               file.WriteLine(st.GetDate().ToString("MM dd yyyy HH mm ss fff"));
               file.WriteLine(st.GetSold().ToString());
           }
           file.Close();
        }

        private void ReadFromFile() // this is private for a really good reason.  this function should only be used by constructor.
        {
            //Read Basic User Data In
            string[] lines = System.IO.File.ReadAllLines(sName + "UserProfile.txt");
            dMoney = double.Parse(lines[0]);
            dPurchases = double.Parse(lines[1]);
            dSales = double.Parse(lines[2]);
            dChargedFees = double.Parse(lines[3]);
            dTransFee = double.Parse(lines[4]);

            lines = System.IO.File.ReadAllLines(sName + "CompanyStock.txt");

            string tempName;
            string tempSymbol;
            double tempSpent;
            double tempEarned;
            double tempShares;


            for (int i = 0; i < lines.Length; i += 5)
            {
                tempName= lines[i];
                tempSymbol = lines[i+1 ];
                tempSpent = double.Parse(lines[i + 2]);
                tempEarned = double.Parse(lines[i + 3]);
                tempShares = double.Parse(lines[i + 4]);
                lCompanyStock.Add(new CompanyStock(tempName,tempSymbol,tempSpent,tempEarned,tempShares));
            }

            lines = System.IO.File.ReadAllLines(sName + "StockTransaction.txt");

            DateTime dt;
            bool tempSold;
            double tempPrice;

            string [] dtSpl; // Date Splitter;

            int month;
            int day;
            int year;
            int hour;
            int minute;
            int second;
            int millisecond;

            for (int i = 0; i < lines.Length; i += 6)
            {
                tempName = lines[i];
                tempSymbol = lines[i + 1];
                tempPrice = double.Parse(lines[i + 2]);
                tempShares = double.Parse(lines[i + 3]);
                dtSpl = lines[i + 4].Split(' ');
                tempSold = bool.Parse(lines[i + 5]);

               
                
                month = int.Parse(dtSpl[0]);
                day = int.Parse(dtSpl[1]);
                year = int.Parse(dtSpl[2]);
                hour = int.Parse(dtSpl[3]);
                minute = int.Parse(dtSpl[4]);
                second = int.Parse(dtSpl[5]);
                millisecond = int.Parse(dtSpl[6]);
                dt = new DateTime(year, month, day, hour, minute, second, millisecond);
                
                lStockTransaction.Add(new StockTransaction(tempName,tempSymbol,tempPrice,tempShares,dt,tempSold));

            }
        }

        public bool BuyStock(String name, string symbol, double price, double shares, DateTime dt)
        {
            if (shares * price > dMoney)
                return false;

            dMoney -= ((shares * price) + dChargedFees);
            dChargedFees += dTransFee;
            dPurchases += (shares * price);
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
                    dSales += (shares * price);
                    lCompanyStock[i].SetEarned(earnedTemp+(shares*price));
                    lCompanyStock[i].SetShares(sharesTemp - shares);

                }
            }
            lStockTransaction.Add(new StockTransaction(name, symbol, price, shares, dt, true));
            dMoney += ((shares * price) - dChargedFees);
            return true;
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
