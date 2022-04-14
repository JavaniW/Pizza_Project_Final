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

namespace Pizza_Project.Forms
{
    public partial class CustomerCreateSelectForm : Form
    {
        private readonly CustomerController _customerController = new CustomerController();

        private string Name = "";
        private string Email = "";
        private string PhoneNumber = "";

        public CustomerCreateSelectForm()
        {
            InitializeComponent();
        }

        private void contentDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomerCreateSelectForm_Load(object sender, EventArgs e)
        {
            this.contentDropdown.SelectedItem = "Find Customer";
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.Name = e.ToString();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            this.Email = e.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = e.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            _customerController.Create(new Customer
            {
                Name = this.Name,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber
            });

            }catch(System.IO.IOException error)
            {
                this.errorText.Text = "Could not create user.";
            }
        }
    }
}
