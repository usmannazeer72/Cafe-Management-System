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
    public partial class ApplyLoyaltyprogram : Form
    {
        public ApplyLoyaltyprogram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loyalty = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            applyProgram(loyalty, id);

        }
        private void applyProgram(string loyalty, int id)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                string query = "INSERT INTO LoyaltyProgram (type,customerid,cafeid) " +
                               "VALUES (@loyalty,@id,@cafeid)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@loyalty", loyalty);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@cafeid", 1);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Program added successfully.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Visible = true;
        }
    }
}
