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

namespace Pizza_Project.Forms
{
    public partial class OrderDetailsForm : Form
    {
        Customer custy;
        Order orddy;
        CustomerController custyController = new CustomerController();
        OrderController orddyController = new OrderController();
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public OrderDetailsForm(string OrderNumber)
        {
            orddy = orddyController.GetOrderByNumber(int.Parse(OrderNumber));
            OrderLabel.Text = orddy.OrderName;
           FillupDataGrid();
           
        }
        public void FillupDataGrid()
        {
            foreach (OrderItems order in orddy.Items)
            {
                var item = new ListViewItem(new string[] {order.ItemTotal.ToString()});
                dataGridView2.Rows.Add(item);

            }
        }
       
    }
}
