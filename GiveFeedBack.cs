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
    public partial class GiveFeedBack : Form
    {
        public GiveFeedBack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);
            int rating = int.Parse(textBox2.Text);
            submitFeedBack(customerid, rating);
        }
        private void submitFeedBack(int customerid, int rating)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                string query = "INSERT INTO Feedback (rating,customerid) " +
                               "VALUES (@rating,@customerid)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@customerid", customerid);
                


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("FeedBack added successfully.");
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
