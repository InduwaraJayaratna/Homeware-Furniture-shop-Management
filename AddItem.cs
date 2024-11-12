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
    public partial class AddItem : Form
    {
        SqlConnection conn;
        SqlCommand cmd1, cmd2, cmd3;
        SqlDataAdapter da1, da2;
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h=new Home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Living living= new Living();
            living.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dining dining=new Dining(); 
            dining.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bedroom bedroom=new Bedroom();
            bedroom.Show();
        }
    }
}
