﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeTrade
{
    class Test
    {
        public void theTest(string[] args)
        {
            Stock stock = new Stock();
            Console.WriteLine(stock.getLatestValue("sdfgsdfg").ToString());

            Console.WriteLine(stock.getChangeInPercent("GOOG").ToString());
            Console.WriteLine(stock.getChange("GOOG").ToString());
            Console.WriteLine(stock.getExchange("GOOG").ToString());
        }

    }
}
