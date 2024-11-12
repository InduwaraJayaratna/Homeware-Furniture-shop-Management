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
    public partial class confirmation : Form
    {
        public confirmation()
        {
            InitializeComponent();
        }

        private void con_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home h=new Home();
            h.Show();
        }
    }
}
