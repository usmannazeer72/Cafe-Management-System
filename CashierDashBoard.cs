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
    public partial class CashierDashBoard : Form
    {
        public CashierDashBoard()
        {
            InitializeComponent();
            LoadTransactionDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POS pOS = new POS();
            pOS.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn();
            l1.Visible = true;
        }
        private void LoadTransactionDetails()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM TransactionDetails";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                        transactionDetailsDataGridView.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderSummary summary = new OrderSummary();
            summary.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesPerCategory salesPerCategory = new SalesPerCategory();
            salesPerCategory.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateReceipt generateReceipt = new GenerateReceipt();
            generateReceipt.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TopSellingItem topSellingItem = new TopSellingItem();
            topSellingItem.Visible = true;
        }
    }
}


