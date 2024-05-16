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
    public partial class ManageInventory : Form
    {
        public ManageInventory()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CMDashboard form9 = new CMDashboard();
            form9.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInventory form19 = new AddInventory();
            form19.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewInventory form14 = new ViewInventory();
            form14.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderfromInventory form15 = new OrderfromInventory();
            form15.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IMDashboard form18 = new IMDashboard();
            form18.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updateinventory form21 = new Updateinventory();
            form21.Visible = true;
        }
    }
}
