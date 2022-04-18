using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.kiosk;

namespace Pizza_Project.Forms
{
    public partial class OrderCreationPage : Form
    {
        private readonly Kiosk kiosk;

        private readonly string customerId;

        public OrderCreationPage(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.kiosk = new Kiosk(this.customerId);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var mainSelectionPage = new MainSelectionPage();
            this.Close();
            mainSelectionPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OrderCreationPage_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + @"\\images\\full-pizza.jpeg";
      
            this.pictureBox3.ImageLocation = path;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var buildPizzaForm = new BuildPizzaForm(kiosk.GetCart());
            buildPizzaForm.Show();
        }
    }
}
