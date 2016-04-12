using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGDB
{
    class clsAccount
    {
        public static clsAccount[] Accounts = new clsAccount[100];

        private string user;
        private string pass;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}

