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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("select * from Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             Form1 rb = new Form1();
            rb.Show();

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Orders");
            CrystalReport1 cry = new CrystalReport1();
            cry.SetDataSource(ds);
            rb.crystalReportViewer1.ReportSource = cry;
            rb.crystalReportViewer1.Refresh();
            con.Close();


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminHome adminHome= new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
