using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;

namespace FreeTradeWindowsForms
{

    public class Search
    {
        List<Company> stocks = new List<Company>();

        public Search()
        {
            initialize();
        }

        public List<string> getStocksList(string filename)
        {
            List<string> allStocks = new List<string>();
            using (StreamReader r = new StreamReader(filename))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    allStocks.Add(line);
                }
            }
            return allStocks;
        }

        public void initialize()
        {
            List<string> allStocks = new List<string>();
            allStocks.AddRange(getStocksList(@"../../Stocks/nyse.csv"));
            allStocks.AddRange(getStocksList(@"../../Stocks/nasdaq.csv"));
            allStocks.AddRange(getStocksList(@"../../Stocks/amex.csv"));
            string[] lines = allStocks.ToArray();
            String[] columns = null;
            Company theCompany = new Company(null, null, null, null, null, 0);
            foreach (String line in lines)
            {

                columns = line.Replace("\"", "").Split(',');

                theCompany.Name = columns[1];
                theCompany.Symbol = columns[0];
                theCompany.Sector = columns[6];
                theCompany.Industry = columns[7];
                theCompany.IPOyear = columns[5];

                stocks.Add(theCompany);
                theCompany = new Company(null, null, null, null, null, 0);
            }
        }

        public List<Company> search(string query)
        {
            if (!String.IsNullOrEmpty(query))
            {
                query = query.ToLower();
                List<Company> results = new List<Company>();
                results.AddRange(stocks.FindAll(x => x.Contains(query)));
                List<Company> result = new List<Company>(results);
                return result;
            }
            return null;
        }
    }
}
