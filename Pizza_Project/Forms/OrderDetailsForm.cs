using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza_Project.database.controllers.data_controllers.menu_controllers;
using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.database.controllers.data_controllers.order_controllers;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class OrderDetailsForm : Form
    {
        
        Order orddy;
        OrderListForm referencedPage;
        CustomerController custyController = new CustomerController();
        OrderController orddyController = new OrderController();
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public OrderDetailsForm(string OrderNumber, OrderListForm referencePage)
        {
            this.referencedPage = referencePage;
            orddy = orddyController.GetOrderByNumber(int.Parse(OrderNumber));
            InitializeComponent();
            FixWindowSize.FixLayout(this);

            label1.Text = "Order #" + orddy.OrderNumber.ToString();
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].HeaderCell.Value = "Quantity";
            dataGridView2.Columns[1].HeaderCell.Value = "Ingredients";
            dataGridView2.Columns[2].HeaderCell.Value = "Total Price";
            //dataGridView2.column
           FillupDataGrid();
           
        }
        public void FillupDataGrid()
        {
            foreach (OrderItems orderItem in orddy.Items)
            {
                dataGridView2.Rows.Add(new string[] { orderItem.Quantity.ToString(), orderItem.ingredientsWrite(), ("$" + orderItem.ItemTotal.ToString()) });

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            referencedPage.Show(); 
            this.Close();
        }
    }
}
