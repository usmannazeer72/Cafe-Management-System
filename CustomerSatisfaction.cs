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
    public partial class CustomerSatisfaction : Form
    {
        public CustomerSatisfaction()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            LoadData2();
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
                    string query = @"
                        SELECT C.customerID, C.customerName, C.Email, C.PhoneNo, AVG(F.rating) AS AverageRating
                        FROM Customers C
                        JOIN FeedBack F ON C.customerID = F.customerid
                        GROUP BY C.customerID, C.customerName, C.Email, C.PhoneNo
                        HAVING AVG(F.rating) > (
                            SELECT AVG(rating) AS OverallAvgRating
                            FROM FeedBack
                        )";


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

        private void LoadData2()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT DISTINCT Cafe.Cafeid, Cafe.CafeName, AVG(FeedBack.rating) AS AvgRating, COUNT(FeedBack.FeedBackid) AS FeedbackCount
                        FROM Cafe
                        LEFT JOIN Orders ON Cafe.Cafeid = Orders.Cafeid
                        LEFT JOIN FeedBack ON Orders.customerid = FeedBack.customerid
                        GROUP BY Cafe.Cafeid, Cafe.CafeName
                        HAVING COUNT(FeedBack.FeedBackid) > 0";


                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView3.DataSource = dataTable;
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
