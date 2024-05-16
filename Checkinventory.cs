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
    public partial class Checkinventory : Form
    {
        public Checkinventory()
        {
            InitializeComponent();
            LoadInventory();
        }


        private void CheckAndUpdateInventory()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = "SELECT Ingredientsid, IngredientName, quantity, unit FROM Ingredients WHERE quantity < 3";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {

                    MessageBox.Show("Inventory quantity is low for some items. Please update inventory.");
                    Updateinventory form21 = new Updateinventory();
                    form21.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Inventory is sufficient.");
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

        private void LoadInventory()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = "SELECT Ingredientsid, IngredientName, quantity, unit FROM Ingredients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewInventory.DataSource = dataTable;


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
        private void button1_Click(object sender, EventArgs e)
        {
            CheckAndUpdateInventory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMDashboard iMDashboard = new IMDashboard();
            iMDashboard.Visible = true;
        }
    }
}
