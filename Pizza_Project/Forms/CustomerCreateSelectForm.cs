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
using Pizza_Project.database.Models.order_info;

namespace Pizza_Project.Forms
{
    public partial class CustomerCreateSelectForm : Form
    {
        private readonly CustomerController _customerController = new CustomerController();

        private string ErrorMsg = "";
        private string CurrentView = "Find Customer";
        private string CustomerId = "";

        private string Name = "";
        private string Email = "";
        private string PhoneNumber = "";

        public CustomerCreateSelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets form content on dropdown change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contentDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.contentDropdown.SelectedItem.Equals("Find Customer"))
            {
                this.errorText.Text = "Find a Customer.";
                this.createCustomerTable.Visible = false;
                this.findCustomerTable.Visible = true;
                this.CurrentView = "Find Customer";
            }else
            {
                this.errorText.Text = "Create a Customer.";
                this.createCustomerTable.Visible = true;
                this.findCustomerTable.Visible = false;
                this.CurrentView = "Create Customer";
            }


        }

        /// <summary>
        /// Sets default layout on first render.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerCreateSelectForm_Load(object sender, EventArgs e)
        {
            this.contentDropdown.SelectedItem = "Find Customer";
            this.errorText.Text = "Find a Customer";
            this.errorText.ForeColor = System.Drawing.Color.White;
            this.errorText.Anchor = AnchorStyles.Left;
            this.createCustomerTable.Visible = false;
            this.findCustomerTable.Visible = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.Name = this.name.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            this.Email = this.email.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = this.phoneNumber1.Text;
        }

        private void phoneNumber2_TextChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = this.phoneNumber2.Text;
        }

        /// <summary>
        /// Chooses what logic to perform based on current view.
        /// 
        /// Displays error if an operation cannot be executed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            ButtonsClicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonsClicked();
        }

        private void ButtonsClicked()
        {
            try
            {
                if (this.CurrentView.Equals("Find Customer"))
                {
                    this.FindCustomer();
                }
                else
                {
                    this.CreateCustomer();
                }

            }
            catch (Exception error)
            {
                this.errorText.Text = this.ErrorMsg;
            }
        }
        
        /// <summary>
        /// Creates a customer.
        /// </summary>
        private void CreateCustomer()
        {
            var cust = _customerController.Create(new Customer
            {
                Orders = new List<Order>(),
                Name = this.Name,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                Id = Identifier.CreateIdentifier()
            });;

            this.CustomerId = cust.Id;
            this.ErrorMsg = "Could not create customer.";

            this.ToOrderCreation();
        }

        
        /// <summary>
        /// Finds a customer.
        /// </summary>
        private void FindCustomer()
        {
            System.Diagnostics.Debug.WriteLine(this.PhoneNumber);
                var cust = _customerController.GetByPhone(this.PhoneNumber);

                if (cust != null)
                {
                    this.CustomerId = cust.Id;
                    this.ToOrderCreation();
                }

                this.ErrorMsg = "Could not find customer";
                this.errorText.Text = this.ErrorMsg;
        }

        private void ToOrderCreation()
        {
            var orderCreationPage = new OrderCreationPage(this.CustomerId);
            this.Hide();
            orderCreationPage.Show();
        }

    }
}
