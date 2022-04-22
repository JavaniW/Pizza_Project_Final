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
        long customerKey;
        public CustomerListPageForm()
        {
            InitializeComponent();
            listOfCustomers = c1.Read();
            CustomerListDataGrid.ColumnCount = 2;
            CustomerListDataGrid.Columns[0].HeaderText = "Name";
            CustomerListDataGrid.Columns[1].HeaderText = "Number";
            CustomerListDataGrid.Columns[0].DefaultCellStyle.Padding = new Padding(5);
            CustomerListDataGrid.Columns[1].DefaultCellStyle.Padding = new Padding(5);
            //CustomerListDataGrid.DataSource = listOfCustomers;
            foreach (var cust in listOfCustomers)
            {
                addToCustomerList(cust);
            }
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            CustomerListDataGrid.Rows.Add(new string[] { "Javani", "7068164058" });
            CustomerListDataGrid.Rows.Add(new string[] { "Wright", "1234567890" });
            addButtonColumn();
        }

        public void addButtonColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "More Info";
            btn.Name = "MoreInfoButton";
            btn.UseColumnTextForButtonValue = true;
            //btn.DefaultCellStyle.Padding = new Padding(0);
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerListDataGrid.Columns.Add(btn);
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

        private void CustomerListPageForm_Load(object sender, EventArgs e)
        {

        }
        // If button inside a cell is clicked
        private void CustomerListDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                customerKey = long.Parse(CustomerListDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                var customerInfoPage = new CustomerInfoPageForm(customerKey);
                this.Update();
                customerInfoPage.Show();
            
                //Application.Run(new CustomerInfoPageForm(customerKey));
                MessageBox.Show(e.ColumnIndex + " " + e.RowIndex + " " + customerKey);
            }
        }
    }
}
