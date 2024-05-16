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
    public partial class CMDashboard : Form
    {
        public CMDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageMenu form4 = new ManageMenu();
            form4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStaff form10 = new ManageStaff();
            form10.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageInventory form13 = new ManageInventory();
            form13.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageFinanaces form16 = new ManageFinanaces();
            form16.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewOrders form17 = new ViewOrders();
            form17.Visible = true;
        }
        private void LoadIngredientStatus()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM IngredientStatusView";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewIngredients.DataSource = dataTable;
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

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadIngredientStatus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn form5 = new LogIn();
            form5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MenuOrderDetails menuOrderDetails = new MenuOrderDetails();
            menuOrderDetails.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerSatisfaction customerSatisfaction = new CustomerSatisfaction();
            customerSatisfaction.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoyaltyProgram loyaltyProgram = new LoyaltyProgram();
            loyaltyProgram.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StaffViews staffViews = new StaffViews();
            staffViews.Visible = true;
        }
    }
}
