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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string ingredientName = Namebox.Text;
                int quantity = Convert.ToInt32(quantitybox.Text);
                string unit = unitbox.Text;
                int inventoryId = Convert.ToInt32(inventorybox.Text);
                int vendorId = Convert.ToInt32(vendorbox.Text);

                string query = "INSERT INTO Ingredients (IngredientName, quantity, unit, inventoryid, Vendorid) " +
                               "VALUES (@IngredientName, @Quantity, @Unit, @InventoryId, @VendorId)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@IngredientName", ingredientName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Unit", unit);
                command.Parameters.AddWithValue("@InventoryId", inventoryId);
                command.Parameters.AddWithValue("@VendorId", vendorId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ingredient added successfully.");

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            addInventory.Visible = true;
        }
    }
}
