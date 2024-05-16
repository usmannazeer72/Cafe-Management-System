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

namespace CafeManagementSystem
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customername = this.NameBox.Text;
            var Email = this.emailBox.Text;
            var Password = this.PasswordBox.Text;
            var PhoneNo = this.phoneBox.Text;
            var HouseNo = this.HouseBox.Text;
            var City = this.CityBox.Text;
            var cnic = this.CnicBox.Text;
           

            string connstring = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = "Insert into Customers values" + "('" + cnic + "','" + customername + "','" + Email + "','" + PhoneNo + "','" + HouseNo + "','" + City + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Customer Rsegister Successfully");

                LogIn f5 = new LogIn();
                f5.Visible = true;

            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn F5 = new LogIn();
            F5.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
