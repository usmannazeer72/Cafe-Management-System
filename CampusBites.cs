namespace CafeManagementSystem
{
    public partial class CampusBites : Form
    {
        public CampusBites()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn F5 = new LogIn();
            F5.Visible = true;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterStaff form2 = new RegisterStaff();
            form2.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterCustomer form3 = new RegisterCustomer();
            form3.Visible = true;
        }
    }
}