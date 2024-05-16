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
    public partial class OrderfromInventory : Form
    {
        public OrderfromInventory()
        {
            InitializeComponent();
            OrderfromInventory1();
        }


        private void Form15_Load(object sender, EventArgs e)
        {

        }
        private void OrderfromInventory1()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT MI.MenuItemID, MI.itemName AS MenuItemName, I.IngredientName, I.quantity, I.unit
                                     FROM MenuItem AS MI
                                     JOIN Items AS IT ON MI.MenuItemID = IT.MenuItemid
                                     JOIN Ingredients AS I ON IT.Ingredientid = I.Ingredientsid";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataGridViewTextBoxColumn colMenuItemID = new DataGridViewTextBoxColumn();
                        colMenuItemID.HeaderText = "MenuItemID";
                        colMenuItemID.DataPropertyName = "MenuItemID";

                        DataGridViewTextBoxColumn colMenuItemName = new DataGridViewTextBoxColumn();
                        colMenuItemName.HeaderText = "MenuItem Name";
                        colMenuItemName.DataPropertyName = "MenuItemName";

                        DataGridViewTextBoxColumn colIngredientName = new DataGridViewTextBoxColumn();
                        colIngredientName.HeaderText = "Ingredient Name";
                        colIngredientName.DataPropertyName = "IngredientName";

                        DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
                        colQuantity.HeaderText = "Quantity";
                        colQuantity.DataPropertyName = "quantity";

                        DataGridViewTextBoxColumn colUnit = new DataGridViewTextBoxColumn();
                        colUnit.HeaderText = "Unit";
                        colUnit.DataPropertyName = "unit";


                        dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                            colMenuItemID, colMenuItemName, colIngredientName, colQuantity, colUnit
                        });

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["MenuItemID"],
                                reader["MenuItemName"],
                                reader["IngredientName"],
                                reader["quantity"],
                                reader["unit"]
                               
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
