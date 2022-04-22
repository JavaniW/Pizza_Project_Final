using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.kiosk;
using Pizza_Project.kiosk.Checkout;

namespace Pizza_Project.Forms
{
    public partial class CheckoutPage : Form
    {
        private readonly Kiosk _kiosk;

        private readonly Customer Customer;

        private bool cashPayment = true;
        private bool orderPickup = true;

        private string CartPrice;

        private string nameOnCard = "";
        private string cardNumber = "";
        private string cardEXP = "";
        private string cardCVC = "";

        private string address = "";
        private string city = "";
        private string state = "";
        private string zipCode = "";


        public CheckoutPage(Kiosk kiosk)
        {
            InitializeComponent();
            this._kiosk = kiosk;
            this.Customer = new CustomerController().GetById(this._kiosk.GetCustomerId());

            //Data grid view elements
            this.itemDataGridView.Columns.Add("itemName", "Item");
            this.itemDataGridView.Columns.Add("itemQuantity", "Quantity");
            this.itemDataGridView.Columns.Add("itemPrice", "Price");
            this.itemDataGridView.AutoSize = true;
            this.itemDataGridView.DefaultCellStyle.ForeColor = Color.White;
            this.itemDataGridView.DefaultCellStyle.BackColor = Color.DimGray;
        }
        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            this.paymentComboBox.SelectedItem = "Cash";
            this.paymentText.Text = "Cash Payment";

            this.deliveryComboBox.SelectedItem = "Pickup";
            this.deliveryText.Text = "Store Pickup";

            // Data grid view show data (READ ONLY)
            var (cartItems, cartPrice) = this._kiosk.GetCart().GetCartDetails();
            this.CartPrice = cartPrice.ToString();

            foreach(var item in cartItems)
            {
                this.itemDataGridView.Rows.Add(item.Name, item.Quantity, item.ItemTotal);
            }

            this.payButton.Text = "Pay $" + cartPrice;
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.paymentComboBox.SelectedItem.Equals("Card")) {
                this.ShowCardInputs();
                this.cashPayment = false;
            }else
            {
                this.cashPayment = true;
                this.paymentInputLayout.Visible = false;
                this.paymentText.Text = "Cash Payment";
            }
        }

        private void ShowCardInputs()
        {

            if (this.Customer.PaymentInfo == null)
            {
                this.paymentText.Text = "Enter Card Information";
                this.paymentInputLayout.Visible = true;
            }  
        }

        private void deliveryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.deliveryComboBox.SelectedItem.Equals("Delivery"))
            {
                this.ShowDeliveryInputs();
                this.orderPickup = false;
            }else
            {
                this.orderPickup = false;
                this.deliveryInputLayout.Visible = false;
                this.deliveryText.Text = "Store Pickup";
            }
        }

        private void ShowDeliveryInputs()
        {
            if (this.Customer.UserAddresses == null)
            {
                this.deliveryText.Text = "Enter Address";
                this.deliveryInputLayout.Visible = true;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            string paymentType = "";
            if (this.cashPayment)
            {
                paymentType = "cash";
            }else
            {
                paymentType = "card";
            }
            this._kiosk.Checkout(paymentType);
            this.Close();
        }

        private void cardDetailsLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nameOnCardInput_TextChanged(object sender, EventArgs e)
        {
            this.nameOnCard = this.nameOnCardInput.Text;
        }

        private void cardNumberInput_TextChanged(object sender, EventArgs e)
        {
            this.cardNumber = this.cardNumberInput.Text;
        }

        private void expInput_TextChanged(object sender, EventArgs e)
        {
            this.cardEXP = this.expInput.Text;
        }

        private void cvcInput_TextChanged(object sender, EventArgs e)
        {
            this.cardCVC = this.cvcInput.Text;
        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {
            this.address = this.addressInput.Text;
        }

        private void cityInput_TextChanged(object sender, EventArgs e)
        {
            this.city = this.cityInput.Text;
        }

        private void stateInput_TextChanged(object sender, EventArgs e)
        {
            this.state = this.stateInput.Text;
        }

        private void zipCodeInput_TextChanged(object sender, EventArgs e)
        {
            this.zipCode = this.zipCodeInput.Text;
        }

    }
}
