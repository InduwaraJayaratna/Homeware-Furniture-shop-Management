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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace CODSE22F_023
{
    public partial class UserDeatails : Form
    {
        SqlConnection con;
        SqlCommand cmd1, cmd2, cmd3;
        SqlDataAdapter da1, da2, da3;
        SqlDataReader dr;
        public void grid()
        {
            try
            {

                string myquery = "select * from UserA";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cusName.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            cusName.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();  
            textBox2.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString(); 
            textBox3.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                cmd1 = new SqlCommand("UPDATE UserA SET CName = '" + cusName.Text + "' WHERE email = '" + textBox2.Text + "'", con);
                int i = cmd1.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Updated", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            grid();
        }

        public UserDeatails()
        {
            InitializeComponent();
        }

        private void UserDeatails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
            con.Open();
            grid();
        }

        private void txtOID_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
