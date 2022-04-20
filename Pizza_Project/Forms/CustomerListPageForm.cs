using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.Models.person_info;

namespace Pizza_Project.Forms
{
    public partial class CustomerListPageForm : Form
    {

        CustomerController c1 = new CustomerController();
        List<Customer> listOfCustomers;
        public CustomerListPageForm()
        {
            listOfCustomers = c1.Read();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListPageForm_Load(object sender, EventArgs e)
        {
            var listOfCustomers = this.listOfCustomers;
            foreach (Customer cx in listOfCustomers)
            {
              //Panel CustomerListPanel = new C;
           // BindingSource customerControllerBindingSource = new BindingSource();

            Button CustomerListBackButton = new Button();
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            Label CustomerName = new Label();
            Button CustomerInfoButton = new Button();
            Label CustomerNumber = new Label();
    }
            
        }

        private void CustomerListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
