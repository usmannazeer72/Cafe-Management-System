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
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             int staffid = int.Parse(this.staffbox.Text);
             int cafeid = int.Parse(this.cafebox.Text);
             DeleteStaff1(staffid,cafeid);
        }
        private void DeleteStaff1(int staffId, int cafeId)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "DELETE FROM staff WHERE  staffid = @staffID AND cafeid = @cafeId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@staffID", staffId);
                cmd.Parameters.AddWithValue("@cafeId", cafeId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("staff member deleted successfully!");


                }
                else
                {
                    MessageBox.Show("Failed to delete staff. staff not found or unauthorized. OR not completed");
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
