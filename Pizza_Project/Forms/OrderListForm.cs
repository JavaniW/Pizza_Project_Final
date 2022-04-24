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
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class OrderListForm : Form
    {
        Customer custy;
        CustomerController custyController = new CustomerController();
        string orderNum;
        public OrderListForm()
        {
            InitializeComponent();

            FixWindowSize.FixLayout(this);
        }

       public OrderListForm(string Number)
        {
            custy = custyController.GetByPhone(Number);
            label1.Text = custy.Name;
            dataGridView1.ColumnCount = 3;
            FillupDataGrid();
            AddButtonColumn();
        }
        public void FillupDataGrid()
        {
            foreach(Order order in custy.Orders){
                var item = new ListViewItem(new string[] {order.OrderNumber.ToString(),order.Items.Count.ToString(),order.OrderTotal.ToString()});
                dataGridView1.Rows.Add(item);
               
            }
        }
        public void AddButtonColumn()
        {
          DataGridViewButtonColumn view= new DataGridViewButtonColumn();
            view.HeaderText = " ";
            view.Text = "View";
            view.Name = "ViewButton";
            view.UseColumnTextForButtonValue = true;
            view.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(view);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                orderNum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                var orderInfo = new OrderDetailsForm(orderNum);
                this.Hide();
                orderInfo.Show();
            }
        }
    }
}
