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
using Pizza_Project.database.Models.customer_info.payment;
using Pizza_Project.database.Models.person_info;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class CheckoutPage : Form
    {
        private readonly Kiosk _kiosk;

        private readonly CustomerController _customerController;
        private readonly Customer Customer;

        private bool cashPayment = true;
        private bool orderPickup = true;

        public bool orderSuccess = false;

        private string CartPrice;

        private string nameOnCard = "";
        private string cardNumber = "";
        private string cardEXP = "";
        private string cardCVC = "";

        private double CashIn = 0;

        private string address = "";
        private string city = "";
        private string state = "";
        private string zipCode = "";


        public CheckoutPage(Kiosk kiosk)
        {
            InitializeComponent();

            FixWindowSize.FixLayout(this);

            this._kiosk = kiosk;
            this._customerController = new CustomerController();
            this.Customer =this._customerController.GetById(this._kiosk.GetCustomerId());

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
            this.ShowCashInputs();

            this.deliveryComboBox.SelectedItem = "Pickup";
            this.deliveryText.Text = "Store Pickup";

            // Data grid view show data (READ ONLY)
            var (cartItems, cartPrice) = this._kiosk.GetCart().GetCartDetails();
            this.CartPrice = cartPrice.ToString();

            foreach(var item in cartItems)
            {
                this.itemDataGridView.Rows.Add(item.Name, item.Quantity, "$"+item.ItemTotal);
            }

            this.payButton.Text = "Confirm $" + cartPrice;
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // display card or cash payment forms.
            if (this.paymentComboBox.SelectedItem.Equals("Card")) {
                this.ShowCardInputs();
                this.cashPayment = false;
            }else
            {
                this.ShowCashInputs();
            }
        }

        private void ShowCashInputs()
        {

            // display cash payment method form (subset of cc info form)
            this.cashPayment = true;
            this.paymentInputLayout.Visible = true;
            this.paymentText.Text = "Cash Payment";

            this.nameOnCardInput.Visible = true;
            this.cardNameLabel.Visible = true;

            this.cardNumberInput.Visible = false;
            this.cardNumberLabel.Visible = false;
            this.cardExpLabel.Visible = false;
            this.expInput.Visible = false;
            this.cardCvcLabel.Visible = false;
            this.cvcInput.Visible = false;

            this.cardNameLabel.Text = "Cash In";
            if (this.nameOnCardInput.Text.Length > 0)
            {
                this.CashIn = double.Parse(this.nameOnCardInput.Text);
            }
        }

        private void ShowCardInputs()
        {
            // display component based on selected dropdown item
            if (this.Customer.PaymentInfo == null)
            {
                this.paymentText.Text = "Enter Card Information";
                this.paymentInputLayout.Visible = true;
                this.cardNameLabel.Text = "Name";
                this.cardNumberInput.Visible = true;
                this.cardNumberLabel.Visible = true;
                this.cardExpLabel.Visible = true;
                this.expInput.Visible = true;
                this.cardCvcLabel.Visible = true;
                this.cvcInput.Visible = true;
            }else
            {
                this.paymentText.Text = "Card Information Exists";
                this.cardNameLabel.Visible = false;
                this.nameOnCardInput.Visible = false;
            }
        }

        private void deliveryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // display component based on selected dropdown item
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
                //display address input layout if customer does not have address
                this.deliveryText.Text = "Enter Address";
                this.deliveryInputLayout.Visible = true;

            }else
            {
                // remove address inputs if customer has an address.
                this.deliveryInputLayout.Visible = false;
                this.deliveryText.Text = "Address Information Exists";
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.orderSuccess = false;
            this.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // set payment type
            CreditCardInfo cardInfo = null;
            string paymentType = "";
            if (this.cashPayment)
            {
                paymentType = "cash";
            }else
            {

                // create customer cc info
                paymentType = "card";

                if (this.cardCvcLabel.Visible == true)
                {
                    cardInfo = new CreditCardInfo
                    {
                        NameOnCard = this.nameOnCard,
                        ExpDate = this.cardEXP,
                        CVC = this.cardCVC,
                        CardNumber = this.cardNumber
                    };
                }
            }

            if (this.deliveryInputLayout.Visible == true)
            {
                // create customer address
                var address = new PersonAddress
                {
                        Address = this.address,
                        City = this.city,
                        State = this.state,
                        ZipCode = this.zipCode
                };

                // add address to customer
                this.Customer.UserAddresses = address;
                this._customerController.UpdateById(Customer.Id, Customer);
            }

            if (this.cashPayment && this.CashIn < double.Parse(this.CartPrice))
            {
                this.paymentText.Text = "Invalid Cash Amount";
                return;
            }

            // checkout cart
            var (order, changeDue) = this._kiosk.Checkout(paymentType, this.CashIn, cardInfo);

            var receiptForm = new RecieptPageForm(order, this.cashPayment, changeDue);
            receiptForm.Show();
            this.orderSuccess = true;
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
            if (this.cashPayment)
            {
                if (this.nameOnCardInput.Text.Equals(""))
                {
                    this.CashIn = 0;
                }else
                {
                    this.CashIn = double.Parse(this.nameOnCardInput.Text);                
                }
            }
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

        private void CheckoutPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
