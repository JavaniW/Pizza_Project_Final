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

        static CustomerController c1 = new CustomerController();
        List<Customer> listOfCustomers = c1.Read();
        public CustomerListPageForm()
        {
            InitializeComponent();
            CustomerListDataGrid.ColumnCount = 2;
            CustomerListDataGrid.Columns[0].HeaderText = "Name";
            CustomerListDataGrid.Columns[1].HeaderText = "Number";
            //CustomerListDataGrid.DataSource = listOfCustomers;
           foreach (var cust in listOfCustomers)
            {
                addToCustomerList(cust);
            }
        }

        public void addToCustomerList(Customer customer)
        {

            var item = new ListViewItem( new String [] {customer.Name, customer.PhoneNumber} );
            Console.WriteLine(item.Text);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.PhoneNumber);
            CustomerListDataGrid.Rows.Add(new String[] { customer.Name, customer.PhoneNumber });
           // CustomerListDataGrid.ite
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListPageForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
