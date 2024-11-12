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
    public partial class AdminHome : Form
    {

        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            LAdmin bl= new LAdmin();
            bl.Show();
            this.Hide();
        }

        private void users_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDeatails userDeatails = new UserDeatails(); 
            userDeatails.Show();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDeatails orderDeatails=new OrderDeatails();
            orderDeatails.Show();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
