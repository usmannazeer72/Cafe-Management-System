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
    public partial class MenuItemsView : Form
    {
        public MenuItemsView()
        {
            InitializeComponent();
            DisplayTasks();
        }
        public void DisplayTasks()
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            using (SqlConnection sql = new SqlConnection(connString))
            {
                sql.Open();
                string query = "SELECT * FROM MenuItem WHERE categoryid = (SELECT categoryid FROM Category WHERE cateoryName = 'Desi')";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            ItemGridView.Columns.Add("itemName", "itemName");
                            ItemGridView.Columns.Add("price", "price");
                            ItemGridView.Columns.Add("description", "description");
                            ItemGridView.Columns.Add("categoryid", "categoryid");
                            ItemGridView.Columns.Add("Cafeid", "Cafeid");

                            while (reader.Read())
                            {
                                string name = reader["itemName"].ToString();
                                string Price = reader["price"].ToString();
                                string Desc = reader["Description"].ToString();
                                string id = reader["categoryid"].ToString();
                                string cafeid = reader["Cafeid"].ToString();
                                ItemGridView.Rows.Add(name, Price, Desc, id, cafeid);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Data");
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
