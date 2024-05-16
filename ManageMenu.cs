using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn F5 = new LogIn();
            F5.Visible = true;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            AddMenu f6 = new AddMenu();
            f6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteMenuitems form8 = new DeleteMenuitems();
            form8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuItemsView form7 = new MenuItemsView();
            form7.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMDashboard form9 = new CMDashboard();
            form9.Visible = true;
        }
    }
}
