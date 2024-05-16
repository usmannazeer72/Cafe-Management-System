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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Amount = int.Parse(AmountBox.Text);
            string method = MethodBox.Text;
            int staffid = int.Parse(ID1Box.Text);
            int Cafeid = int.Parse(ID2Box.Text);
            int Orderid = int.Parse(ID3Box.Text);
            addPOS(Amount, method, staffid, Cafeid, Orderid);
        }
        private void addPOS(int amount, string method, int staffid, int Cafeid, int Orderid)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "INSERT INTO Transactions (amount, method, Cafeid, Orderid, staffid) " +
                      "VALUES (@Amount, @Method, @Cafeid, @Orderid, @Staffid)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Method", method);
                cmd.Parameters.AddWithValue("@Cafeid", Cafeid);
                cmd.Parameters.AddWithValue("@Orderid", Orderid);
                cmd.Parameters.AddWithValue("@Staffid", staffid);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("item added successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to add item.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDashBoard cashierDashBoard = new CashierDashBoard();
            cashierDashBoard.Visible =true;
        }
    }
}
