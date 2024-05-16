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
    public partial class GreaterThanAvgQuantity : Form
    {
        public GreaterThanAvgQuantity()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMDashboard iMDashboard = new IMDashboard();
            iMDashboard.Visible = true;
        }

        private void LoadData()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = @"
                        SELECT Ingredientsid, Ingredientname, SUM(quantity) AS TotalQuantity
                        FROM Ingredients
                        GROUP BY Ingredientsid, Ingredientname
                        HAVING SUM(quantity) > (SELECT AVG(quantity) FROM Ingredients)";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
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
                sqlConnection.Close();
            }
        }
    }
}
