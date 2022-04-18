using System;
using System.Windows.Forms;

namespace Pizza_Project.Forms
{
    public partial class MainSelectionPage : Form
    {
        public MainSelectionPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainSelectionPage_Load(object sender, EventArgs e)
        {

        }

        private void ViewOrderText_Click(object sender, EventArgs e)
        {

        }

        private void TakeOrderText_Click(object sender, EventArgs e)
        {
            this.TakeOrderPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.TakeOrderPage();
        }

        private void TakeOrderPage()
        {
            var customerCreateSelectForm = new CustomerCreateSelectForm();
            this.Hide();
            customerCreateSelectForm.Show();
        }
    }
}
