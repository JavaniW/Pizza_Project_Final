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
        string customerKey;
        public CustomerListPageForm()
        {
            InitializeComponent();
            listOfCustomers = c1.Read();
            CustomerListDataGrid.ColumnCount = 2;
            CustomerListDataGrid.Columns[0].HeaderText = "Name";
            CustomerListDataGrid.Columns[1].HeaderText = "Number";
            CustomerListDataGrid.Columns[0].DefaultCellStyle.Padding = new Padding(5);
            CustomerListDataGrid.Columns[1].DefaultCellStyle.Padding = new Padding(5);

            int currentRow = 0;
            foreach (var cust in listOfCustomers)
            {
                addToCustomerList(cust);
                CustomerListDataGrid.Rows[currentRow].HeaderCell.Value = cust.Id;
                currentRow++;  
            }
            addButtonColumn();
        }

        public void addButtonColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "More Info";
            btn.Name = "MoreInfoButton";
            btn.UseColumnTextForButtonValue = true;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerListDataGrid.Columns.Add(btn);
        }
        public void addToCustomerList(Customer customer)
        {

            var item = new ListViewItem( new String [] {customer.Name, customer.PhoneNumber} );
            CustomerListDataGrid.Rows.Add(new String[] { customer.Name, customer.PhoneNumber });
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerListPageForm_Load(object sender, EventArgs e)
        {

        }
        // If button inside a cell is clicked
        private void CustomerListDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                customerKey = (string)CustomerListDataGrid.Rows[e.RowIndex].HeaderCell.Value;
                var customerInfoPage = new CustomerInfoPageForm(customerKey, this);
                this.Hide();
                customerInfoPage.Show();
            
            }
        }
    }
}
