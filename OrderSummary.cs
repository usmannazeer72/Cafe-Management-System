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
    public partial class OrderSummary : Form
    {
        public OrderSummary()
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
            try
            {

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT o.orderid, o.customerid, o.status, SUM(mi.price) AS totalamount " +
                                   "FROM orders o " +
                                   "JOIN orderitem oi ON o.orderid = oi.orderid " +
                                   "JOIN menuitem mi ON oi.itemid = mi.menuitemid " +
                                   "GROUP BY o.orderid, o.customerid, o.status";


                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }


                    dataGridView1.DataSource = dataTable;


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierDashBoard cashierDashBoard = new CashierDashBoard();
            cashierDashBoard.Visible = true;
        }
    }
}
