using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CODSE22F_023
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public static string email;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
        }

        private void sign_Click(object sender, EventArgs e)
        {
            email = Email.Text;

            if (Email.Text=="")
            {
                MessageBox.Show("Requirements should be filled","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Requirements should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Open();
            try
            {

                da = new SqlDataAdapter("Select Count (*) from UserA where Email = '" + Email.Text + "' and pass = '" + Password.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home h=new Home();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Invalid USERNAME or PASSWORD Please Try Again", "Registration FAILD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = "";
                    Password.Text = "";
                    Email.Focus();
                    Password.Focus();

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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
