using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.NameBox.Text;
            string Desc = this.DescBox.Text;
            int id = int.Parse(this.IDbox.Text);
            int price = int.Parse(this.PriceBox.Text);
            if (string.IsNullOrWhiteSpace(name) || id == 0)
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            addNewItem(name, price, Desc, id);
        }

        private void addNewItem(string name,int price,string desc,int id)
        {
            string connString = "Data Source=DESKTOP-M65O6PF\\SQLEXPRESS;Initial Catalog=CafeSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO MenuItem (price, itemName, Description, categoryid,Cafeid) " +
                               "VALUES (@Price, @Name, @Desc, @Categoryid,@cafeid)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Desc", desc);
                cmd.Parameters.AddWithValue("@Categoryid", id);
                cmd.Parameters.AddWithValue("@cafeid", 1);


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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddMenu form6 = new AddMenu();
            form6.Visible = true;
        }
    }
}
