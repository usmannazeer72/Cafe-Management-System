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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CampusBites F1 = new CampusBites();
            F1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.EmailBox.Text;
            string password = this.PassBox.Text;
            bool isCustomer = this.checkBox1.Checked;
            bool isInventory = this.checkBox2.Checked;
            bool isCashier = this.checkBox3.Checked;
            bool isCafe = this.checkBox4.Checked;

            if (isCustomer)
            {
                LoginAsCustomer(email, password);
            }
            else if (isInventory)
            {
                LoginAsRole(email, password, "Inventory Manager", "Login successful as inventory manager!");
            }
            else if (isCashier)
            {
                LoginAsRole(email, password, "Cashier", "Login successful as cashier!");
            }
            else if (isCafe)
            {
                LoginAsRole(email, password, "Cafe Manager", "Login successful as Cafe manager!");
                
            }
            else
            {
                MessageBox.Show("Please select a user type.");
            }
        }

        private void LoginAsCustomer(string email, string password)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM customers WHERE email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful as customer!");
                        CustomerPortal customerPortal = new CustomerPortal();
                        customerPortal.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password for customer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoginAsRole(string email, string password, string role, string successMessage)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM staff WHERE email = @Email AND Password = @Password AND role = @Role";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show(successMessage);
                        if (role == "Cafe Manager")
                        {
                            CMDashboard f9 = new CMDashboard();
                            f9.Visible = true;
                        }
                        else if (role == "Inventory Manager")
                        {
                            IMDashboard form18 = new IMDashboard();
                            form18.Visible = true;
                        }
                        else if( role == "Cashier")
                        {
                            CashierDashBoard f9 = new CashierDashBoard();
                            f9.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password for " + role.ToLower() + ".");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
