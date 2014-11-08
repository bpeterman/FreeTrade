using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeTradeWindowsForms
{
    public partial class MainForm : Form
    {
        List<Company> results = new List<Company>;
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            results = new List<Company>;
            searchResults.Items.Clear();
            string query = searchBox.Text;
            Search search = new Search();
            results = search.search(query);
            if (results != null)
            {
                foreach (Company company in results)
                {
                    searchResults.Items.Add(String.Format("{0} - {1}", company.Name, company.Symbol));
                }
            }
            Stock stock = new Stock();
            MessageBox.Show(stock.getLatestValue("GOOG").ToString());
        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = searchResults.SelectedIndex;
            Company company = results[index];

        }
    }
}
