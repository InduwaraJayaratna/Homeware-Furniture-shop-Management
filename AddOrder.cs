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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CODSE22F_023
{
    public partial class AddOrder : Form
    {
        SqlConnection conn;
        SqlCommand cmd1, cmd2, cmd3;
        SqlDataAdapter da1, da2;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItem ai = new AddItem();
            ai.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                cmd1 = new SqlCommand("insert into PaymentList(CName, email, Caddress, tp,cardno,cvv) values('" + textBox1.Text + "','" + Login.email + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"')", conn);
                int i = cmd1.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Order Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    confirmation confirmation = new confirmation();
                    confirmation.Show();
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
            finally
            {
                conn.Close();
            }
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
             
        }

            private void cash_CheckedChanged(object sender, EventArgs e)
            {


            }

            private void card_CheckedChanged(object sender, EventArgs e)
            {

            }
        }
    } 
