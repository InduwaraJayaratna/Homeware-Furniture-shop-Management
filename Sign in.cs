using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODSE22F_023
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l=new Login();
            l.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LAdmin lAdmin= new LAdmin();
            lAdmin.Show();
        }
    }
}
