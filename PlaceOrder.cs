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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);
            int itemid = int.Parse(textBox3.Text);
            PlaceOrderWithItem(customerid, itemid);
        }
        private void PlaceOrderWithItem(int customerid, int itemid)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                string orderInsertQuery = "INSERT INTO Orders (customerid,staffid) VALUES (@customerId,@staffid); SELECT SCOPE_IDENTITY();";
                SqlCommand orderCommand = new SqlCommand(orderInsertQuery, sqlConnection);
                orderCommand.Parameters.AddWithValue("@customerid", customerid);
                orderCommand.Parameters.AddWithValue("@staffid",1);
                int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                if (orderId > 0)
                {
                   
                    string orderItemInsertQuery = "INSERT INTO Orderitem (orderid, itemid) VALUES (@orderid, @itemid);";
                    SqlCommand orderItemCommand = new SqlCommand(orderItemInsertQuery, sqlConnection);
                    orderItemCommand.Parameters.AddWithValue("@orderid", orderId);
                    orderItemCommand.Parameters.AddWithValue("@itemid", itemid);

                    int rowsAffected = orderItemCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order placed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to place order item.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to place order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
