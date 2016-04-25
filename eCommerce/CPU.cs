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
    public partial class CPU : Form
    {
        public CPU()
        {
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {

        }

        private void cboCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pcbCPU.Image = Image.FromFile("/Images/i5.jpg");
            pcbCPU.ImageLocation = @"i5.jpg";
        }
    }
}
