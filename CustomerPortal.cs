using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class CustomerPortal : Form
    {
        public CustomerPortal()
        {
            InitializeComponent();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Visible = true;
        }

        private void LoadData()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT MenuItem.MenuItemID, MenuItem.itemName, Category.cateoryName, Cafe.CafeName, MenuItem.price
                                    FROM MenuItem
                                    INNER JOIN Category ON MenuItem.categoryid = Category.categoryid
                                    INNER JOIN Cafe ON MenuItem.Cafeid = Cafe.Cafeid";


                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiveFeedBack giveFeedBack = new GiveFeedBack();
            giveFeedBack.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyLoyaltyprogram applyLoyaltyprogram = new ApplyLoyaltyprogram();
            applyLoyaltyprogram.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentOffers styers = new StudentOffers();
            styers.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RepeatingCustomers repeatingCustomers = new RepeatingCustomers();
            repeatingCustomers.Visible = true;
        }
    }
}
