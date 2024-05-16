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
    public partial class SalesPerCategory : Form
    {
        public SalesPerCategory()
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
                    string query = "SELECT c.cateoryname, SUM(mi.price) AS totalsales " +
                                    "FROM menuitem mi " +
                                    "JOIN category c ON mi.categoryid = c.categoryid " +
                                    "GROUP BY c.cateoryname " +
                                    "ORDER BY totalsales DESC";


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
