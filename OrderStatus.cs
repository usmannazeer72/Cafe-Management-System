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
    public partial class OrderStatus : Form
    {
        public OrderStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";

            int orderId = int.Parse(IDBox1.Text);
            int customerId = int.Parse(IDBox2.Text);
            string newStatus = status.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Orders SET status = @NewStatus " +
                                         "WHERE Orderid = @OrderId AND customerid = @CustomerId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@CustomerId", customerId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Order status update failed. Check Order ID and Customer ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMDashboard cMDashboard = new CMDashboard();
            cMDashboard.Visible = true;
        }
    }
}
