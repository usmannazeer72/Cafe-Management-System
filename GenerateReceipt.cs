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
    public partial class GenerateReceipt : Form
    {
        public GenerateReceipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            LoadData(id);
        }


        private void LoadData(int id)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT c.customerName, mi.itemname, o.date as orderDate, o.time as orderTime, t.amount
                                    FROM customers c
                                    JOIN orders o ON c.customerid = o.customerid
                                    JOIN orderitem oi ON o.orderid = oi.orderid
                                    JOIN menuitem mi ON oi.itemid = mi.menuitemid
                                    JOIN transactions t ON t.orderid = o.orderid
                                    WHERE c.customerid = @customerId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", id);

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

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDashBoard cashierDashBoard = new CashierDashBoard();
            cashierDashBoard.Visible =true;
        }
    }
}
