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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterStaff form = new RegisterStaff();
            form.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteStaff form11 = new DeleteStaff();
            form11.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStaff form12 = new UpdateStaff();
            form12.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CMDashboard form9 = new CMDashboard();
            form9.Visible = true;
        }
    }
}
