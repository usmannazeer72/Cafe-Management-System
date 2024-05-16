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
    public partial class ManageFinanaces : Form
    {
        public ManageFinanaces()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(CustomerId.Text);
            int staffId = Convert.ToInt32(StaffId.Text);
            string status = Status.Text;
            int totalBill = Convert.ToInt32(TotalBill.Text);
            AddNewOrder(customerId, staffId, status, totalBill);
        }

        private void AddNewOrder(int customerId, int staffId, string status, int totalBill)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {

                sqlConnection.Open();
                string insertQuery = "INSERT INTO Orders (customerid, staffid, status, TotalBill,cafeid) " +
                                     "VALUES (@customerId, @staffId, @status, @totalBill,@cafeid)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.Parameters.AddWithValue("@customerId", customerId);
                insertCommand.Parameters.AddWithValue("@staffId", staffId);
                insertCommand.Parameters.AddWithValue("@status", status);
                insertCommand.Parameters.AddWithValue("@totalBill", totalBill);
                insertCommand.Parameters.AddWithValue("@cafeid", 1);


                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order added successfully.");
                    LoadFinancialData();
                    GenerateFinancialReports();
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

        private void LoadFinancialData()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Orders";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewOrders.DataSource = dataTable;
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

        private void GenerateFinancialReports()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string reportQuery = "SELECT SUM(TotalBill) AS TotalSales FROM Orders";
                SqlCommand reportCommand = new SqlCommand(reportQuery, sqlConnection);
                SqlDataReader reader = reportCommand.ExecuteReader();

                if (reader.Read())
                {
                    int totalSales = Convert.ToInt32(reader["TotalSales"]);
                    labelTotalSales.Text = totalSales.ToString();

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

        private void Form16_Load(object sender, EventArgs e)
        {
            LoadFinancialData();
            GenerateFinancialReports();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMDashboard form9 = new CMDashboard();
            form9.Visible = true;
        }
    }

}
