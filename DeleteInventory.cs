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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                int ingredientid = int.Parse(id2box.Text);
                int inventoryid = int.Parse(id1box.Text);

                if (ingredientid != null && inventoryid != null)
                {
                    sqlConnection.Open();
                    string deleteQuery = "DELETE FROM Ingredients WHERE Ingredientsid = @ingredientid AND inventoryid =@inventoryid";
                    SqlCommand command = new SqlCommand(deleteQuery, sqlConnection);
                    command.Parameters.AddWithValue("@ingredientid", ingredientid);
                    command.Parameters.AddWithValue("@inventoryid", inventoryid);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingredient deleted successfully.");
                        id1box.Text = string.Empty;
                        id2box.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Ingredient not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an ingredient name to delete.");
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
            Form20 form20 = new Form20();
            form20.Visible = true;
            
        }
    }
}
