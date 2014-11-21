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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getUsername()
        {
            return usernameBox.Text;
        }

        public string getPassword()
        {
            return passBox.Text;
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
        }
    }
}
