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
    public partial class LoyaltyProgram : Form
    {
        public LoyaltyProgram()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
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

                    string query = @"SELECT c.customername, l.type
                                    FROM customers c
                                    JOIN loyaltyProgram l ON c.customerid = l.customerid";

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
        private void LoadData1()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT customerID, customerName, City, PhoneNo FROM Customers WHERE customerID IN (SELECT customerid FROM loyaltyProgram WHERE type = 'premium');";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
