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
    public partial class Updateinventory : Form
    {
        public Updateinventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                int ingredientid = Convert.ToInt32(IDbox.Text);
                int newQuantity = Convert.ToInt32(QuantityBox.Text);
                int inventoryId = Convert.ToInt32(ID2box.Text);
                sqlConnection.Open();
                string updateQuery = "UPDATE Ingredients SET quantity = @NewQuantity WHERE inventoryid = @InventoryId and Ingredientsid =@ingredientid";
                SqlCommand command = new SqlCommand(updateQuery, sqlConnection);
                command.Parameters.AddWithValue("ingredientid", ingredientid);
                command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                command.Parameters.AddWithValue("@InventoryId", inventoryId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inventory updated successfully.");
                    IDbox.Text = ""; 
                    QuantityBox.Text = "";
                    ID2box.Text = "";
                }
                else
                {
                    MessageBox.Show("No inventory record found for the provided ID.");
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
    }
}
