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

namespace Pizza_Project.Forms
{
    public partial class RecieptPageForm : Form
    {
        private readonly List<OrderItems> CartItems;
        private readonly double CartTotal;

        private string Signiture = "";
        private bool DisplayError = false;

        public RecieptPageForm(List<OrderItems> cartItems, double cartTotal)
        {
            InitializeComponent();

            this.itemDataGridView.Columns.Add("itemName", "Item");
            this.itemDataGridView.Columns.Add("itemPrice", "Price");
            this.itemDataGridView.AutoSize = true;
            this.itemDataGridView.DefaultCellStyle.ForeColor = Color.White;
            this.itemDataGridView.DefaultCellStyle.BackColor = Color.DimGray;

            this.CartItems = cartItems;
            this.CartTotal = cartTotal;
        }

        private void RecieptPageForm_Load(object sender, EventArgs e)
        {
            this.totalPriceLabel.Text = "$" + this.CartTotal;
            foreach (var item in this.CartItems)
            {
                var totalString = "$" + item.ItemTotal;
                this.itemDataGridView.Rows.Add(item.Name, totalString);
            }
        }

        private void signitureInput_TextChanged(object sender, EventArgs e)
        {
            this.Signiture = this.signitureInput.Text;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (this.Signiture.Length > 0)
            {
                this.Close();
            }

            this.DisplayError = true;
            this.errorLabel.Text = "Please type a valid signiture.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LayoutPanelReceiptPage_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
