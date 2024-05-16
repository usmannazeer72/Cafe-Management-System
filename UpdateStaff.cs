using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.EmailBox.Text;
            string Phone = this.PhoneBox.Text;
            string House = this.HouseNo.Text;
            int salary = int.Parse(this.Salary.Text);
            int id = int.Parse(this.idbox.Text);
            Updatestaff(email, Phone, House, salary, id);
        }
        
        private void Updatestaff(string email, string PhoneNo, string HouseNo, int salary, int id)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "UPDATE staff SET email = @Email, phoneNo = @Phone, houseNo = @House,salary = @Salary WHERE staffid = @ID ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ID", id);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", PhoneNo);
                cmd.Parameters.AddWithValue("@House", HouseNo);
                cmd.Parameters.AddWithValue("@Salary", salary);
                
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Staff updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update staff. Staff not found or unauthorized.");
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
