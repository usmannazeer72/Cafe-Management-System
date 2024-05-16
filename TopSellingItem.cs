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
    public partial class TopSellingItem : Form
    {
        public TopSellingItem()
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

                    string query = @"SELECT menuitem.itemname, COUNT(orderitem.itemid) AS totalorders
                                    FROM orderitem
                                    JOIN menuitem ON orderitem.itemid = menuitem.menuitemid
                                    WHERE menuitem.cafeid = 1
                                    GROUP BY menuitem.itemname
                                    ORDER BY totalorders DESC";
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
            CashierDashBoard dashboard = new CashierDashBoard();    
            dashboard.Visible = true;
        }
    }
}
