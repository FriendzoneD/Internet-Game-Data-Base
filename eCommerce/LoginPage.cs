using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGDB
{
    public partial class LoginPage : Form
    {
        clsAccount[] Account = new clsAccount[100];

        public LoginPage()
        {
            MessageBox.Show("Welcome To Storm!");
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool userTest = false;

            for (int i = 0; i < 100; i++)
            {
                if (clsAccount.Accounts[i] == null)
                {
                    break;
                }
                else
                {
                    if (txtUsername.Text == clsAccount.Accounts[i].User && txtPassword.Text == clsAccount.Accounts[i].Pass)
                    {
                        this.Hide();
                        MainMenu Accounts = new MainMenu();
                        Accounts.Show();
                        userTest = true;
                    }
                }

            }

            if (!userTest)
            {
                MessageBox.Show("Invalid username and passowrd!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            MessageBox.Show("Information Cleared");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration form3 = new Registration();
            form3.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
