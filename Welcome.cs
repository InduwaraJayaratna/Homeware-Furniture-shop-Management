using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODSE22F_023
{
    public partial class Welcome : Form
    {
        

        public Welcome()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s=new signin();
            s.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
