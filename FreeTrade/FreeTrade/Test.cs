using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeTrade
{
    class Test
    {
        public void Test(string[] args)
        {
            Stock stock = new Stock();
            Console.WriteLine(stock.getLatestValue("Goog").ToString());

        }

    }
}
