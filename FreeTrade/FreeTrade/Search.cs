using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace FreeTrade
{
    public class Search
    {
        List<Company> nyse=  new List<Company>();
        public Search()
        {
        }
        public void initialize()
        {
            string[] lines = System.IO.File.ReadAllLines(@"Stocks/nyse.csv");
            String[] columns=null;
            Company theCompany = new Company(null, null, null, null, null);
            foreach(String line in lines)
            {
                columns = line.Split(',');

                theCompany.Name = columns[1];
                theCompany.Symbol= columns[0];
                theCompany.Sector = columns[6];
                theCompany.Industry = columns[7];
                theCompany.IPOyear = columns[5];

                nyse.Add(theCompany);
                theCompany = new Company(null, null, null, null, null);

            }
        }

        public ObservableCollection<Company> search(String query)
        {
            List<Company> results = new List<Company>();
            results.AddRange(nyse.FindAll(x => x.Name.Contains(query)));
            results.AddRange(nyse.FindAll(x => x.Symbol.Contains(query)));
            results.AddRange(nyse.FindAll(x => x.Sector.Contains(query)));
            results.AddRange(nyse.FindAll(x => x.Industry.Contains(query)));
            results.AddRange(nyse.FindAll(x => x.IPOyear.Contains(query)));
            return new ObservableCollection<Company>(results);
        }
    }
}
