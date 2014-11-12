using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction
{
    class CompanyStock
    {
        String sName;
        string sSymbol;
        double dSpent;
        double dEarned;
        double dShares;

        public CompanyStock()
        {
            sName = "default";
            sSymbol = "dt";
            dSpent = 0;
            dEarned = 0;
            dShares = 0;
        }

        public CompanyStock(string name, string symbol, double spent, double earned, double shares)
        {
           if(!SetName(name)) // bad name entered
           {
              sName = "Error";
           }
            if(!SetSymbol(symbol))
            {
               sSymbol = "err";
            }

            if(!SetSpent(spent))
            {
               dSpent = 0.0;
            }

            if(!SetEarned(earned)) // again an error by the user.
            {
               dEarned = 0.0;
            }

            if(!SetShares(shares))
            {
               dShares = 0.0;
            }
        
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
            return sSymbol;
        }

        public bool SetSymbol(string symbol)
        {
            if (symbol.Length > 0)
            {
                sSymbol = symbol;
                return true;
            }
            return false;
        }

        public double GetSpent()
        {
            return dSpent;
        }

        public bool SetSpent(double spent)
        {
            if (spent >= 0.0)
            {
                dSpent = spent;
                return true;
            }
            return false;
        }

        public double GetEarned()
        {
            return dEarned;
        }

        public bool SetEarned(double earned)
        {
            if (earned >= 0.0)
            {
                dEarned = earned;
                return true;
            }
            return false;
        }

        public double GetShares()
        {
            return dShares;
        }


        public bool SetShares(double shares)
        {
            if (shares >= 0.0)
            {
                dShares = shares;
                return true;
            }
            return false;
        }

    }
}
