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
    public partial class RepeatingCustomers : Form
    {
        public RepeatingCustomers()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT o.customerid, c.customerName, COUNT(o.orderid) AS totalorders
                        FROM orders o
                        JOIN customers c ON o.customerid = c.customerid
                        GROUP BY o.customerid, c.customername
                        HAVING COUNT(o.orderid) >= 2";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Visible = true;
        }
    }
}
