using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FreeTradeWindowsForms
{

    struct PurchasedStockInfo
    {
        public string Name;
        public string Symbol;
        public string NumOfShares;
        public string NumOfInitialShares;
        public string PurchasePrice;
        public string Date;
    }

    struct SoldStockInfo
    {
        public string Name;
        public string Symbol;
        public string NumOfShares;
        public string PurchasePrice;
        public string SoldPrice;
        public string PurchaseDate;
        public string SoldDate;
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
            ReadFromFile();
        }

        public UserProfile(string name, double money)
        {
            sName = name;
            dMoney = money;
            lPurchasedStocks = new List<PurchasedStock>();
            lSoldStocks = new List<SoldStock>();
            ReadFromFile();
        }

        List<PurchasedStockInfo> GetPurchasedStockDescriptor()
        {
            List<PurchasedStockInfo> temp = new List<PurchasedStockInfo>();

            PurchasedStockInfo psi = new PurchasedStockInfo();

            foreach (PurchasedStock ps in lPurchasedStocks)
            {
                psi = new PurchasedStockInfo();
                psi.Name = ps.GetName();
                psi.Symbol = ps.GetSymbol();
                psi.NumOfShares = ps.GetNumOfShares().ToString();
                psi.NumOfInitialShares = ps.GetInitalNumOfShares().ToString();
                psi.PurchasePrice = ps.GetPrice().ToString();
                psi.Date = ps.GetPurchaseDate().ToString("MM/dd/yyyy HH:mm:ss:fff");

                temp.Add(psi);
            }
            return temp;
        }

        public List<SoldStockInfo> GetSoldStockDescriptor()
        {


            List<SoldStockInfo> temp = new List<SoldStockInfo>();

            SoldStockInfo ssi = new SoldStockInfo();

            foreach (SoldStock ss in lSoldStocks)
            {
                ssi = new SoldStockInfo();
                ssi.Name = ss.GetName();
                ssi.Symbol = ss.GetSymbol();
                ssi.NumOfShares = ss.GetNumOfShares().ToString();
                ssi.PurchasePrice = ss.GetPrice().ToString();
                ssi.SoldPrice = ss.GetSoldPrice().ToString();
                ssi.PurchaseDate = ss.GetPurchaseDate().ToString("MM/dd/yyyy HH:mm:ss:fff");
                ssi.SoldDate = ss.GetSoldDate().ToString("MM/dd/yyyy HH:mm:ss:fff");
                temp.Add(ssi);
            }
            return temp;
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
                dMoney -= (ps.GetPrice() * ps.GetInitalNumOfShares());
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
        public void WriteToFile()
        {
            //2 lines
            System.IO.File.WriteAllText(sName + "userdata.txt", sName + Environment.NewLine + dMoney.ToString());

            System.IO.StreamWriter file = new System.IO.StreamWriter(sName + "purchasedstocks.txt", false);
            foreach (PurchasedStock p in lPurchasedStocks)
            {
                //6 lines
                file.WriteLine(p.GetName());
                file.WriteLine(p.GetSymbol());
                file.WriteLine(p.GetInitalNumOfShares());
                file.WriteLine(p.GetNumOfShares());
                file.WriteLine(p.GetPrice());
                file.WriteLine(p.GetPurchaseDate().ToString("MM dd yyyy HH mm ss fff"));
            }
            file.Close();

            file = new System.IO.StreamWriter(sName + "soldstocks.txt", false);
            foreach (SoldStock s in lSoldStocks)
            {   //7 lines
                file.WriteLine(s.GetName());
                file.WriteLine(s.GetSymbol());
                file.WriteLine(s.GetNumOfShares());
                file.WriteLine(s.GetSoldPrice());
                file.WriteLine(s.GetPrice());
                file.WriteLine(s.GetPurchaseDate().ToString("MM dd yyyy HH mm ss fff"));
                file.WriteLine(s.GetSoldDate().ToString("MM dd yyyy HH mm ss fff"));
            }
            file.Close();
        }

        private void StringPurListStockBuilder(string stock_name, string stock_symbol, string init_num_shares, string num_shares, string st_price, string pur_date)
        {
            // MM dd yyyy HH mm ss fff
            string[] dtstring = pur_date.Split(' ');
            DateTime Temp;

            int month = int.Parse(dtstring[0]);
            int day = int.Parse(dtstring[1]);
            int year = int.Parse(dtstring[2]);
            int hour = int.Parse(dtstring[3]);
            int minute = int.Parse(dtstring[4]);
            int second = int.Parse(dtstring[5]);
            int millisecond = int.Parse(dtstring[6]);

            Temp = new DateTime(year, month, day, hour, minute, second, millisecond);

            float fNumInitShare = float.Parse(init_num_shares);
            float fNumShares = float.Parse(num_shares);
            double dStPrice = double.Parse(st_price);

            lPurchasedStocks.Add(new PurchasedStock(stock_name, stock_symbol, dStPrice, fNumShares, fNumInitShare, Temp));

        }
        private void StringSoldListStockBuilder(string stock_name, string stock_symbol, string num_shares, string sold_price, string st_price, string pur_date, string sold_date)
        {

            string[] dtstring = pur_date.Split(' ');
            DateTime PurTemp, SoldTemp;

            int month = int.Parse(dtstring[0]);
            int day = int.Parse(dtstring[1]);
            int year = int.Parse(dtstring[2]);
            int hour = int.Parse(dtstring[3]);
            int minute = int.Parse(dtstring[4]);
            int second = int.Parse(dtstring[5]);
            int millisecond = int.Parse(dtstring[6]);

            PurTemp = new DateTime(year, month, day, hour, minute, second, millisecond);

            dtstring = sold_date.Split(' ');
            month = int.Parse(dtstring[0]);
            day = int.Parse(dtstring[1]);
            year = int.Parse(dtstring[2]);
            hour = int.Parse(dtstring[3]);
            minute = int.Parse(dtstring[4]);
            second = int.Parse(dtstring[5]);
            millisecond = int.Parse(dtstring[6]);

            SoldTemp = new DateTime(year, month, day, hour, minute, second, millisecond);

            float fNumShares = float.Parse(num_shares);
            double dSoldPrice = double.Parse(sold_price);
            double dStPrice = double.Parse(st_price);


            lSoldStocks.Add(new SoldStock(stock_name, stock_symbol, dStPrice, fNumShares, dSoldPrice, PurTemp, SoldTemp));
        }
        private bool ReadFromFile()
        {
            try
            {
                string[] user = File.ReadAllLines(sName + "userdata.txt");

                if (user.Length == 2)
                {
                    sName = user[0];
                    dMoney = double.Parse(user[1]);
                }


                string stock_name = "";
                string stock_symbol = "";
                string init_num_shares = "";
                string num_shares = "";
                string stock_price = "";
                string pur_date = "";

                string[] purStock = File.ReadAllLines(sName + "purchasedstocks.txt");
                for (int i = 0; i < purStock.Length; i++)
                {
                    switch (i % 6)
                    {
                        case 0:
                            stock_name = purStock[i];
                            break;
                        case 1:
                            stock_symbol = purStock[i];
                            break;
                        case 2:
                            init_num_shares = purStock[i];
                            break;
                        case 3:
                            num_shares = purStock[i];
                            break;
                        case 4:
                            stock_price = purStock[i];
                            break;
                        case 5:
                            pur_date = purStock[i];
                            StringPurListStockBuilder(stock_name, stock_name, init_num_shares, num_shares, stock_price, pur_date);
                            break;
                    }
                }




                string[] soldStock = File.ReadAllLines(sName + "soldstocks.txt");
                string sold_price = "";
                string sold_date = "";
                for (int i = 0; i < soldStock.Length; i++)
                {
                    switch (i % 7)
                    {
                        case 0:
                            stock_name = soldStock[i];
                            break;
                        case 1:
                            stock_symbol = soldStock[i];
                            break;
                        case 2:
                            num_shares = soldStock[i];

                            break;
                        case 3:
                            sold_price = soldStock[i];
                            break;
                        case 4:
                            stock_price = soldStock[i];
                            break;
                        case 5:
                            pur_date = soldStock[i];
                            break;
                        case 6:
                            sold_date = soldStock[i];
                            StringSoldListStockBuilder(stock_name, stock_symbol, num_shares, sold_price, stock_price, pur_date, sold_date);
                            break;
                    }
                }


                Console.WriteLine(user.Length + " " + purStock.Length + " " + soldStock.Length);

            }
            catch (FileNotFoundException FE)
            {
                return false;
            }
            return true;
        }

    }


}
