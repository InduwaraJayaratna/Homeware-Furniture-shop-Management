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
using System.Data.SqlClient;


namespace CODSE22F_023
{
    public partial class Living : Form
    {
        SqlConnection con;
        SqlCommand cmd1, cmd2, cmd3;
        SqlDataAdapter da1, da2, da3;
        SqlDataReader dr;

        public void grid()
        {

            string myquery = "select * from Orders where CName ='" + textBox1.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void add_Click(object sender, EventArgs e)
        {
             try
            {
                pay.Visible = true;
                cmd3 = new SqlCommand("INSERT INTO Orders (CName, email, Prod_Name, Total)VALUES('" + textBox1.Text + "','" + Login.email + "','" + comboBox1.Text + "'," + textBox5.Text + ")", con);
                int i = cmd3.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Data Added", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                da1 = new SqlDataAdapter("select * from Orders where Email = '" + Login.email + "' ", con);

                DataTable d1 = new DataTable();
                da1.Fill(d1);


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

        private void pay_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOrder addOrder = new AddOrder();
            addOrder.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd2 = new SqlCommand("SELECT Price FROM Product WHERE Prod_Name = '" + comboBox1.Text + "'", con);
            da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt2.Rows.Count > 0)
            {
                decimal Price = Convert.ToDecimal(dt2.Rows[0]["Price"]);
                textBox2.ReadOnly = false;
                textBox2.Text = Price.ToString();
                textBox2.ReadOnly = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = Convert.ToDecimal(textBox2.Text);
            int qty = Convert.ToInt32(numericUpDown1.Value.ToString());
            decimal ans = tot * qty;
            textBox5.Text = ans.ToString();
        }

        public Living()
        {
            InitializeComponent();
        }

        private void Living_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
            cmd1 = new SqlCommand("Select CName from UserA where Email='" + Login.email + "'", con);

            con.Open();
            da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count > 0)
            {
                string username = dt1.Rows[0]["CName"].ToString();
                textBox1.Text = username;

            }
            grid();
        }
        
    

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItem ai=new AddItem();
            ai.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
