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
        private readonly Cart _cart;
        private readonly CheckoutHandler _checkoutHandler;
        private readonly Customer Customer;

        private readonly string customerId;

        private bool showPaymentInputs = false;
        private bool showAddressInputs = false;

        private string nameOnCard = "";
        private string cardNumber = "";
        private string cardEXP = "";
        private string cardCVC = "";

        private string address = "";
        private string city = "";
        private string state = "";
        private string zipCode = "";


        public CheckoutPage(Cart cart, string customerId)
        {
            InitializeComponent();
            this._cart = cart;
            this.customerId = customerId;
            this.Customer = new CustomerController().GetById(customerId);
        }
        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            this.paymentComboBox.SelectedItem = "Cash";
            this.paymentText.Text = "Cash Payment";

            this.deliveryComboBox.SelectedItem = "Pickup";
            this.deliveryText.Text = "Store Pickup";
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.paymentComboBox.SelectedItem.Equals("Card")) {
                this.ShowCardInputs();
            }else
            {
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
            }else
            {
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
