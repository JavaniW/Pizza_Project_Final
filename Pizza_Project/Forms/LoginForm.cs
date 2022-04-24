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
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class LoginForm : Form
    {
        private string Email = "";
        private string Password = "";

        public LoginForm()
        {
            InitializeComponent();
            FixWindowSize.FixLayout(this);
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
                this.username.Text = "";
                this.password.Text = "";
                this.errorMsgLabel.Visible = false;

                var mainSelectionForm = new MainSelectionPage();
                mainSelectionForm.Show();
                this.Close();
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
