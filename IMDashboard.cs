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
    public partial class IMDashboard : Form
    {
        public IMDashboard()
        {
            InitializeComponent();
            LoadCafeInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageInventory form13 = new ManageInventory();
            form13.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn form5 = new LogIn();
            form5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkinventory form22 = new Checkinventory();
            form22.Visible = true;
        }

        private void LoadCafeInventory()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM CafeInventoryView";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewInventory.DataSource = dataTable;
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

        private void button4_Click(object sender, EventArgs e)
        {
            IngredientsMenuItems menuItem = new IngredientsMenuItems();
            menuItem.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GreaterThanAvgQuantity greaterThanAvgQuantity = new GreaterThanAvgQuantity();
            greaterThanAvgQuantity.Visible = true;
        }
    }
}
