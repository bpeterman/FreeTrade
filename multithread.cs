using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;
using System.Diagnostics;

/****** Available functions to call ***********
string getAnnualizedGain(string symbol)
string getExchange(string symbol)
double getChange(string symbol)   
string getChangeInPercent(string symbol)
double getStockYearHigh(string symbol)
double getStockYearLow(string symbol)
string getCompanyName(string symbol)
double getLatestValue(string symbol)
*/


namespace stockme
{
    class Program
    {

        static void Main(string[] args)
        {
            const int NUM_THREADS = 1;  //reccomended 36 symbols per thread 
            ArrayList arList = new ArrayList();
            ArrayList qrResults;
            Stopwatch sw = new Stopwatch();
            // (284 * 2) symbols is suggested for stress test.
            arList.Add("goog"); arList.Add("A");  arList.Add("AA");  arList.Add("AA-B");  arList.Add("HBI");  arList.Add("HCN"); arList.Add("HE"); arList.Add("HF");
            
            
            //ThreadStockerWrapper(threads,function_name,stocknames_arraylist);
            ThreadStockWrapper Stocker = new ThreadStockWrapper(NUM_THREADS,"getLatestValue",arList); //see available functions above to call.
            sw.Start();
            qrResults = Stocker.threadStockCall(); // returns back a QuerryResults ArrayList();
            sw.Stop();
            foreach(QueryResults qr in qrResults)
            {
                if (qr.isString)
                {
                    Console.WriteLine(qr.sSymbol + " " + qr.sResult + " " + qr.sQuery);
                }
                else
                {   //results have a double instead.
                    Console.WriteLine(qr.sSymbol + " " + qr.dResult + " " + qr.sQuery);
                }
            
            }
            Console.WriteLine("Elapsed Miliseconds " + sw.ElapsedMilliseconds);
        }
    }


    /*begin Class QueryResults ***** brandon ****/
    class QueryResults
    {

        private string symbol, str_result, query;
        private double dbl_result;
        private bool bIsStr; // is the result a string.. if false it is a double.
        public QueryResults(string s, double d, string r, string q, bool isStr)
        {
  
            sSymbol =  s;
            dResult = d;
            sResult = r;
            sQuery = q;
            bIsStr = isStr;

        }

        public bool isString // if false the result is a double;
        {
            get { return bIsStr; }
            set {}
        }

        public string sSymbol
        {
            get{return symbol;}
            set{symbol = value;}
        }
        public double dResult
        {
            get { return dbl_result; }
            set { dbl_result = value; }
        }
        public string sResult
        {
            get { return str_result; }
            set { str_result = value; }
        }
        public string sQuery
        {
            get { return query; }
            set {query = value; }
        }

    }
    /*begin Class ThreadStockWrapper ***** brandon ****/
    class ThreadStockWrapper
    {
        private int iThreads;
      
        private string sFunction;
        private ArrayList arStockSymbols; 
        private ArrayList []arThreadStorage, arResults;
        private StockDrone[] sdDrones;
        private Thread[] tThreads;
        public ThreadStockWrapper(int threads, string function,ArrayList stockSymbols)
        {
            iThreads = threads;
            sFunction = function;
            arStockSymbols = stockSymbols;

            arThreadStorage = new ArrayList[threads];
            arResults = new ArrayList[threads];
            sdDrones = new StockDrone[threads];
            tThreads = new Thread[threads];

            for(int i = 0; i < threads; i++)
            {
                arResults[i] = new ArrayList();
                arThreadStorage[i] = new ArrayList();
            }

            for (int i = 0; i < stockSymbols.Count; i++)
            {
                arThreadStorage[i % threads].Add(stockSymbols[i]); // distributing the load equally.
            }
            for (int i = 0; i < threads; i++)
            { 
               sdDrones[i] = new StockDrone(arThreadStorage[i],arResults[i]); //prep each drone, storage of symbols, and results storage.
               tThreads[i] = new Thread(sdDrones[i].dispatchFunction); // assign each drone as a thread.
            }
        }

        public ArrayList threadStockCall()
        {
            ArrayList arTemp = new ArrayList();
            for (int i = 0; i < iThreads; i++) // puts our drones to work.
            {
                tThreads[i].Start(sFunction);
            }
            while (StockDrone.getThreadCount() > 0) { }  // Wait for all drones to finish


            for (int i = 0; i < iThreads; i++)
            {
                foreach(QueryResults qr in arResults[i])
                {
                    arTemp.Add(qr);  // combine the work of the drones
                }
            
            }
            return arTemp;
        }


    }
/****Begin Class StockDrone *** Brandon ***/

    public class StockDrone  // drone class.  this will be our worker bees
    {
        private static int iThreadCount  = 0;
        private static object locker = new Object();
        private ArrayList stockSymbols, results;
        public StockDrone(ArrayList s, ArrayList r)
        {
            stockSymbols = s;
            results = r;
            lock (locker)
            {
                iThreadCount++;
            }
        }
        public void dispatchFunction(object oFunction)//paramatized threads can only have objects as parameters
        {
            string sFunction = (string) oFunction;
            Stock stock = new Stock();
            if (sFunction.Length >= 4)
            {
                char temp = sFunction.ToUpper().ElementAt(3);
                char temp2 = sFunction.ToUpper().ElementAt(sFunction.Length - 1);
               //  public QueryResults(string s, double d, string r, string q, bool isString)
                switch (temp)
                {
                    case 'A':
                        foreach(string s in stockSymbols)
                        {
                            results.Add(new QueryResults(s,0.0,stock.getAnnualizedGain(s),"getAnnualizedGain",true));
                        }
                        break;
                    case 'C':
                        if (temp2 == 'E')
                        {
                            //getChange
                            foreach (string s in stockSymbols)
                            {
                                results.Add(new QueryResults(s,stock.getChange(s),"", "getChange", false));
                            }
                        }
                        if (temp2 == 'T')
                        {
                            // getChangeInPercent
                            foreach (string s in stockSymbols)
                            {
                                results.Add(new QueryResults(s, 0.0, stock.getChangeInPercent(s), "getChangeInPercent", true));
                            }
                        }
                        break;
                    case 'E':
                        // getExchange
                        foreach (string s in stockSymbols)
                        {
                            results.Add(new QueryResults(s, 0.0, stock.getExchange(s), "getExchange", true));
                        }
                        break;
                    case 'L':
                        //getLatestValue
                        foreach (string s in stockSymbols)
                        {   //false means the result is a double.
                            results.Add(new QueryResults(s, stock.getLatestValue(s), "", "getLatestValue", false));
                        }
                        break;
                    case 'S':
                        if (temp2 == 'H')
                        {  //getStockYearHigh
                            foreach (string s in stockSymbols)
                            {   //false means the result is a double.
                                results.Add(new QueryResults(s, stock.getStockYearHigh(s), "", "getStockYearHigh", false));
                            }
                        }
                        if (temp2 == 'W')
                        {   //getStockYearLow
                            foreach (string s in stockSymbols)
                            {   //false means the result is a double.
                                results.Add(new QueryResults(s, stock.getStockYearLow(s), "", "getStockYearLow", false));
                            }
                        }
                        break;
                    
                }

            }
            lock (locker)
            {
                iThreadCount--;
            }
         }
        public static int getThreadCount()
        {
                return iThreadCount;
        }
    } 

    /*begin Class Stock ******** blake */
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
        // returns an array of strings. Each arg is it's own element in the array.
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

