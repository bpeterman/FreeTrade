using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace FreeTrade
{
    class Stock
    {
        // This doesn't work properly
        public string getAnnualizedGain(string symbol)
        {
            return getFromAPIquoute(symbol, "g3")[0];
        }


        public string getExchange(string symbol)
        {
            return getFromAPIquoute(symbol, "x0")[0];
        }

        public double getChange(string symbol)
        {
            return Convert.ToDouble(getFromAPIquoute(symbol, "c1")[0]);
        }

        public string getChangeInPercent(string symbol)
        {
            return getFromAPIquoute(symbol, "p2")[0];
        }

        public double getStockYearHigh(string symbol)
        {
            return Convert.ToDouble(getFromAPIquoute(symbol, "k0")[0]);
        }
        public double getStockYearLow(string symbol)
        {
            return Convert.ToDouble(getFromAPIquoute(symbol, "j0")[0]);
        }

        // This method will return a string with the company name based on the symbol.
        public string getCompanyName(string symbol)
        {
            return getFromAPIquoute(symbol, "n")[0].Substring(1, getFromAPIquoute(symbol, "n")[0].Length - 4);
        }

        public double getLatestValue(string symbol)
        {
            return Convert.ToDouble(getFromAPIquoute(symbol, "l1")[0]);
        }

        // Stock Symbol
        // args listed here https://code.google.com/p/yahoo-finance-managed/wiki/enumQuoteProperty 
        // returns an array of strings.  Each arg is it's own element in the array.
        private string[] getFromAPIquoute(string symbol, string args)
        {
            string[] results = null;
            try
            {
                string temp = null;
                string yahooURL = @"http://download.finance.yahoo.com/d/quotes.csv?s=" +
                                      symbol + "&f=" + args;
                // Initialize a new WebRequest.
                HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(yahooURL);
                // Get the response from the Internet resource.
                HttpWebResponse webresp = (HttpWebResponse)webreq.GetResponse();
                // Read the body of the response from the server.
                StreamReader strm =
                  new StreamReader(webresp.GetResponseStream(), Encoding.ASCII);
                temp = strm.ReadToEnd();
                results = temp.Split(new Char[] { ',' });
                strm.Close();
            }
            catch
            {
                //some exception
            }
            return results;
        }
        public string getHistory(string symbol, DateTime from, DateTime to, char interval)
        {
            //string[] results = null;
            string temp = null;
            try
            {
                string yahooURL = @"http://ichart.yahoo.com/table.csv?s=" +
                                      symbol + "&a=" + (from.Month - 1).ToString() + "&b=" + 
                                      (from.Day).ToString() + "&c=" + (from.Year).ToString() + "&d=" + 
                                      (to.Month - 1).ToString() + "&e=" + (to.Day).ToString() + "&f=" +
                                      (to.Year).ToString() + "&g=" + interval.ToString() + "&ignore=.csv";
                // Initialize a new WebRequest.
                HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(yahooURL);
                // Get the response from the Internet resource.
                HttpWebResponse webresp = (HttpWebResponse)webreq.GetResponse();
                // Read the body of the response from the server.
                StreamReader strm =
                  new StreamReader(webresp.GetResponseStream(), Encoding.ASCII);
                temp = strm.ReadToEnd();
                //results = temp.Split(new Char[] { ',' });
                //results[0] = temp;
                strm.Close();
            }
            catch
            {
                //some exception
            }
            return temp;
        }
    }
}
