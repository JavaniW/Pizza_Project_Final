using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.database.Models.order_info;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class RecieptPageForm : Form
    {
        private readonly Order Order;
        private readonly double ChangeDue;

        private readonly bool CashPayment;

        private string Signature = "";

        public RecieptPageForm(Order order, bool cashPayment, double changeDue)
        {
            InitializeComponent();

            FixWindowSize.FixLayout(this);

            this.itemDataGridView.Columns.Add("itemName", "Item");
            this.itemDataGridView.Columns.Add("itemPrice", "Price");
            this.itemDataGridView.Columns["itemPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.itemDataGridView.Columns["itemPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.itemDataGridView.AutoSize = true;
            this.itemDataGridView.DefaultCellStyle.ForeColor = Color.White;
            this.itemDataGridView.DefaultCellStyle.BackColor = Color.DimGray;

            this.Order = order;
            this.ChangeDue = changeDue;
            this.CashPayment = cashPayment;
        }

        private void RecieptPageForm_Load(object sender, EventArgs e)
        {
            if (this.CashPayment)
            {
                this.signitureInput.Visible = false;
                this.signatureLabel.Text = "Change due";
                this.changeDueLabel.Text = "$" + this.ChangeDue;
            }

            this.orderNumberText.Text = "Order #" + this.Order.OrderNumber.ToString();
            this.totalPriceLabel.Text = "$" + this.Order.OrderTotal;
            foreach (var item in this.Order.Items)
            {
                var totalString = "$" + item.ItemTotal;
                this.itemDataGridView.Rows.Add(item.Name, totalString);
            }
        }

        private void signitureInput_TextChanged(object sender, EventArgs e)
        {
            this.Signature = this.signitureInput.Text;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(this.Signature);
            if ((!this.Signature.Equals("") && this.CashPayment == false) || this.CashPayment == true)
            {
                var mainSelectionForm = new MainSelectionPage();
                mainSelectionForm.Show();
                this.Close();
            }

            this.errorLabel.Text = "Please type a valid signiture.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LayoutPanelReceiptPage_Paint(object sender, PaintEventArgs e)
        {
        }

        private void signitureInput_TextChanged_1(object sender, EventArgs e)
        {
            this.Signature = this.signitureInput.Text;
        }
    }
}
