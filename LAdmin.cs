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
    public partial class LAdmin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public LAdmin()
        {
            InitializeComponent();
        }

        private void LAdmin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
        }

        private void sign_Click(object sender, EventArgs e)
        {


            try
            {

                da = new SqlDataAdapter("Select Count (*) from adminlog where ad_name = '" + txt_username.Text + "' and pass = '" + txt_password.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminHome ah= new AdminHome(); 
                    ah.Show();
                }
                else
                {
                    MessageBox.Show("Invalid USERNAME or PASSWORD Please Try Again", "Registration FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_username.Focus();
                    txt_password.Focus();
                   
                }
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin signin = new signin();
            signin.Show();
        }
    }
}
