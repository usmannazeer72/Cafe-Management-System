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
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
            DisplayInventory();
        }
        private void DisplayInventory()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection sql = new SqlConnection(connString))
            {
                try
                {
                    sql.Open();
                    string query = "SELECT * FROM Ingredients"; // Ensure table name is spelled correctly
                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                InventoryGridView.Columns.Add("ingredientsid", "ingredientsid");
                                InventoryGridView.Columns.Add("ingredientname", "ingredientname");
                                InventoryGridView.Columns.Add("Unit", "Unit");
                                InventoryGridView.Columns.Add("Quantity", "Quantity");
                                InventoryGridView.Columns.Add("Vendorid", "Vendorid");
                                InventoryGridView.Columns.Add("inventoryid", "inventoryid");

                                while (reader.Read())
                                {
                                    string id = reader["ingredientsid"].ToString();
                                    string name = reader["ingredientname"].ToString();
                                    string unit = reader["Unit"].ToString();
                                    string quantity = reader["Quantity"].ToString();
                                    string id2 = reader["Vendorid"].ToString();
                                    string id3 = reader["inventoryid"].ToString();
                                    InventoryGridView.Rows.Add(id, name, unit, quantity, id2, id3);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No Data");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
