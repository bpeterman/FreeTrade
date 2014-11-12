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

        string sName;

        private double dMoney;
        private double dPurchases;
        private double dSales;
        private double dChargedFees;
        private double dTransFee;

        UserProfile()
        {
            sName = "default";
            dMoney = 5000.0;
            dPurchases = 0.0;
            dSales = 0.0;
            dChargedFees = 0.0;
            dTransFee = 7.00;
        }
        UserProfile(string name)
        {
           //loading constructor.
           //loads user data from file.
        }

        /*Buy Stock To Be Implimented */

        /*End Buy Stock*/

        /*Begin sale stock*/

        /*End Sale stock*/

        UserProfile(string name, double money, double transFee)
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

        double GetMoney()
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

        double GetPurchases()
        {
            return dPurchases;
        }

        bool SetPurchases(double pur)
        {
            if (pur >= 0)
            {
                dPurchases = 0.0;
                return true;
            }
            return false;
        }

        double GetSales()
        {
            return dSales;
        }

        bool SetSales(double sales)
        {
            if (sales >= 0)
            {
                dSales = sales;
                return true;
            }
            return false;
        }

        double GetChargedFee()
        {
            return dTransFee;
        }

        bool SetChargedFee(double charged)
        {
            if (charged >= 0.0)
            {
                dChargedFees = charged;
                return true;
            }
            return false;
        }

        double GetTransActionFee()
        {
            return dTransFee;
        }

        bool SetTransActionFee(double transFee)
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
