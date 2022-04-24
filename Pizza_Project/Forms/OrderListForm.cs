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
using Pizza_Project.database.controllers.data_controllers.order_controllers;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class OrderListForm : Form
    {
        MainSelectionPage referencedPage;
        static OrderController orderController = new OrderController();
        List<Order> orders = orderController.GetAllOrders();
        CustomerController custyController = new CustomerController();
        string orderNum;
        public OrderListForm(MainSelectionPage referencedPage)
        {
            this.referencedPage = referencedPage;
            InitializeComponent();

            FixWindowSize.FixLayout(this);
            label1.Text = "Orders";
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "Order Number";
            dataGridView1.Columns[1].HeaderText = "Item Count";
            dataGridView1.Columns[2].HeaderText = "Order Total";
            FillupDataGrid();
            AddButtonColumn();
        }

       /*public OrderListForm(string Number)
        {
            custy = custyController.GetByPhone(Number);
            label1.Text = custy.Name;
            dataGridView1.ColumnCount = 3;
            FillupDataGrid();
            AddButtonColumn();
        }*/
        public void FillupDataGrid()
        {
            int rowNumber = 0;
            foreach (Order order in orders){
                dataGridView1.Rows.Add(new string[] { order.OrderNumber.ToString(), order.Items.Count.ToString(), ("$" + order.OrderTotal.ToString()) });
                dataGridView1.Rows[rowNumber].HeaderCell.Value = order.OrderNumber;
                rowNumber++;
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
                orderNum = dataGridView1.Rows[e.RowIndex].HeaderCell.Value.ToString();
                var orderInfo = new OrderDetailsForm(orderNum, this);
                this.Hide();
                orderInfo.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            referencedPage.Show();
            this.Close();
        }
    }
}
