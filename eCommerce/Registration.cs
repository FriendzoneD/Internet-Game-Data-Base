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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void CreateAccounts(int id, string user, string pass)
        {
            clsAccount.Accounts[id] = new clsAccount();
            clsAccount.Accounts[id].User = user;
            clsAccount.Accounts[id].Pass = pass;
        }

        private void btnNextReg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (clsAccount.Accounts[i] == null && txtPass.Text == txtRetypePass.Text)
                {
                    this.Hide();
                    CreateAccounts(i, txtUser.Text, txtPass.Text);
                    MessageBox.Show("Registration Successful");
                    break;
                }

                else
                {
                    MessageBox.Show("Password do not match!");
                    txtRetypePass.Clear();
                    break;
                }
            }
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
