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

namespace CODSE22F_023
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void sign_Click(object sender, EventArgs e)
        {
            try
            {
                string name, Email;
                string pass, repass;

                name = nametxt.Text;
                Email = Emailtxt.Text;
                pass = passtxt.Text;
                repass = repasstxt.Text;

                if (nametxt.Text == "" || nametxt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Requirement Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Emailtxt.Text == "")
                {
                    MessageBox.Show("Requirement Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passtxt.Text == "")
                {
                    MessageBox.Show("Requirement Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (repasstxt.Text == "")
                {
                    MessageBox.Show("Requirement Should be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    con.Open();
                    cmd = new SqlCommand("insert into UserA values('" + nametxt.Text + "','" + Emailtxt.Text + "','" + passtxt.Text + "')", con);
                    double i = cmd.ExecuteNonQuery();

                    if (passtxt.Text == repasstxt.Text)
                    {
                        if (i == 1)
                        {
                            MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Home h=new Home();
                            h.Show();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Re-enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        repasstxt.Text = "";
                    }
                    con.Close();
                }
                
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l=new Login();
            l.ShowDialog();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-3HQ6LQPL;Initial Catalog=Furniture;Integrated Security=True");
        }
    }

    }

