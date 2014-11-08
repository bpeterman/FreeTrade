//brandon


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            int millisecond = temp.Millisecond;
            temp = new DateTime(year, month, day, hour, minute, second,millisecond);



            Console.WriteLine("money {0}", up.GetMoney());
            //up.PurchaseStock(new PurchasedStock("bubba", "Bu", 20.00, 12, 12, temp));
            // public PurchasedStock(string name, string symbol, double purPrice, float numOfShares, float initialNumOfShares, DateTime dt) 
            
            Console.WriteLine("money {0}",up.GetMoney());
            //up.SellStock("bubba", "bu", temp, DateTime.Now, 10, 28.50);
            Console.WriteLine("money {0}", up.GetMoney());
            //up.WriteToFile();
        }

    }

    
   
}
