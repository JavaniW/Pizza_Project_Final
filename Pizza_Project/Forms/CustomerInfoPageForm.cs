using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza_Project.database.Models;
using Pizza_Project.database.Models.customer_info;
using Pizza_Project.database.controllers.data_controllers.person_controllers;
using Pizza_Project.database.controllers.data_controllers.abstract_classes;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class CustomerInfoPageForm : Form
    {
        CustomerController c2 = new CustomerController();
        //CustomerListPageForm referenceForm;
        Customer customerMain;

        public CustomerInfoPageForm(string customerKey, CustomerListPageForm referenceForm)
        {
            InitializeComponent();
            //this.referenceForm = referenceForm;
            //this.Owner = referenceForm;
            FixWindowSize.FixLayout(this);

            customerMain = c2.GetById(customerKey);
            System.Diagnostics.Debug.WriteLine(customerKey);
            FillInLabel();
            if (customerMain == null)
            {
                //referenceForm.Show();
                this.Close();
            } else
            {
                InitializeComponent();
                FillInLabel();
            }
        }

        private void FillInLabel()
        {
            NameReplaceLabel.Text = customerMain.Name;
            NumberReplaceLabel.Text = customerMain.PhoneNumber;

            if (customerMain.UserAddresses != null)
            {
                var personAddress = customerMain.UserAddresses;
                string addressString = $"{personAddress.Address}, {personAddress.City}, {personAddress.State} {personAddress.ZipCode}";

                this.AddressReplaceLabel.Text = addressString;
            }   
         
            if (customerMain.PaymentInfo != null)
            {
                CardholderNameReplaceLabel.Text = customerMain.PaymentInfo.NameOnCard;
                CardNumberReplaceLabel.Text = customerMain.PaymentInfo.CardNumber;
                ExpDateReplaceLabel.Text = customerMain.PaymentInfo.ExpDate;
                CVCReplaceLabel.Text = customerMain.PaymentInfo.CVC;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CustomerInfoPageForm_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
