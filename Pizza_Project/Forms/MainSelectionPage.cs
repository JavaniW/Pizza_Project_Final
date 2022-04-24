using System;
using System.Windows.Forms;

using Pizza_Project.helper_classes;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class MainSelectionPage : Form
    {
        public MainSelectionPage()
        {
            InitializeComponent();

            FixWindowSize.FixLayout(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainSelectionPage_Load(object sender, EventArgs e)
        {
            this.pictureBox2.ImageLocation = FilePath.GetPath(@"\\images\\pizza-slice.jpeg");
            this.pictureBox1.ImageLocation = FilePath.GetPath(@"\\images\\list.jpeg");
            this.pictureBox3.ImageLocation = FilePath.GetPath(@"\\images\\customer.jpeg");

        }

        private void ViewOrderText_Click(object sender, EventArgs e)
        {
            this.ViewOrderList();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ViewOrderList();
        }

        private void ViewOrderList()
        {
            var orderListForm = new OrderListForm();
            this.Hide();
            orderListForm.ShowDialog();
            this.Show();
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
            this.Close();
            customerCreateSelectForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.DisplayCustomerList();
        }

        private void ViewCustomerInfoText_Click(object sender, EventArgs e)
        {
            this.DisplayCustomerList();
        }

        private void DisplayCustomerList()
        {
            var customerListForm = new CustomerListPageForm(this);
            this.Hide();
            customerListForm.ShowDialog();
            this.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
  
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
