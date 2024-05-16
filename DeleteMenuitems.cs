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
    public partial class DeleteMenuitems : Form
    {
        public DeleteMenuitems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse(this.ItemBox.Text);
            int categoryid = int.Parse(this.Categorybox.Text);
            DeleteItem(itemid, categoryid);
        }
        private void DeleteItem(int itemId, int categoryId)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "DELETE FROM menuitem WHERE  menuitemid = @itemId AND categoryid = @categoryid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@itemId", itemId);
                cmd.Parameters.AddWithValue("@categoryid", categoryId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete item. Item not found or unauthorized. OR not completed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
