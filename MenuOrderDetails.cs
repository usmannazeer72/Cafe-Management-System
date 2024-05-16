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
    public partial class MenuOrderDetails : Form
    {
        public MenuOrderDetails()
        {
            InitializeComponent();
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT customers.customerid, customers.customername, orders.orderid, orders.date, menuitem.itemname, menuitem.price
                                    FROM customers
                                    JOIN orders ON customers.customerid = orders.customerid
                                    JOIN orderitem ON orders.orderid = orderitem.orderid
                                    JOIN menuitem ON orderitem.itemid = menuitem.menuitemid";

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
            CMDashboard cMDashboard = new CMDashboard();
            cMDashboard.Visible = true;
        }
    }
}
