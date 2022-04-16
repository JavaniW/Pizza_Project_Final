using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza_Project.authentication;

namespace Pizza_Project.Forms
{
    public partial class LoginForm : Form
    {
        private string Email = "";
        private string Password = "";

        public LoginForm()
        {
            InitializeComponent();
        }
        private void username_TextChanged(object sender, EventArgs e)
        {
            this.Email = this.username.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            this.Password = this.password.Text;
        }

        private void login_Click(object sender, EventArgs e)
        {
            var auth = new Authentication();
            if(auth.Login(this.Email, this.Password))
            {
                // Load form 2 here.
                System.Diagnostics.Debug.WriteLine("Logged in");
                var mainSelectionForm = new MainSelectionPage();
                mainSelectionForm.Show();
            }
            else
            {
                // show error message here
                this.errorMsgLabel.Visible = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
