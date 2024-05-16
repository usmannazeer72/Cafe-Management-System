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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeManagementSystem
{
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = this.NameBox.Text;
            var email = this.EmailBox.Text;
            var password = this.PasswordBox.Text;
            var phoneNo = this.PhoneBox.Text;
            var houseNo = this.HouseBox.Text;
            var role = this.RoleBox.Text;
            var city = this.CityBox.Text;
            var cnic = this.CNICBox.Text;
            var salary = this.SalaryBox.Text;
            var cafeid = this.IdBox.Text;

            string connstring = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = "Insert into staff values" + "('" + name + "','" + cnic + "','" + salary + "','" + houseNo + "','" + city + "','" + phoneNo + "','" + email + "','" + role + "','" + cafeid + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Staff Rsegister Successfully");

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
