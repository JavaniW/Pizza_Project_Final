using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.kiosk;
using Pizza_Project.helper_classes;

namespace Pizza_Project.Forms
{
    public partial class OrderCreationPage : Form
    {
        private readonly Kiosk _kiosk;

        private readonly string customerId;

        public OrderCreationPage(string customerId)
        {
            InitializeComponent();

            FixWindowSize.FixLayout(this);

            this.customerId = customerId;
            this._kiosk = new Kiosk(this.customerId);
            this.dataGridView1.Columns.Add("itemName", "Cart Item");
            this.dataGridView1.Columns.Add("itemQuantity", "Quantity");
            this.dataGridView1.AutoSize = true;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            {
                editButton.Text = "Delete";
                editButton.UseColumnTextForButtonValue = true; //dont forget this line
                editButton.DefaultCellStyle.BackColor = Color.Red;
                editButton.DefaultCellStyle.ForeColor = Color.White;
                editButton.FlatStyle = FlatStyle.Flat;
                this.dataGridView1.Columns.Add(editButton);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var mainSelectionPage = new MainSelectionPage();
            this.Close();
            mainSelectionPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OrderCreationPage_Load(object sender, EventArgs e)
        {
            
            this.buildPizzaImg.ImageLocation = FilePath.GetPath(@"\\images\\full-pizza.jpeg");
            this.beverageImage.ImageLocation = FilePath.GetPath(@"\\images\\beverage.jpg");
        }

        private void buildPizzaButton_Click(object sender, EventArgs e)
        {
            this.BuildPizzaFormLoader();
        }
        private void buildPizzaImg_Click(object sender, EventArgs e)
        {
            this.BuildPizzaFormLoader();
        }

        private void BuildPizzaFormLoader()
        {
            var buildPizzaForm = new BuildPizzaForm(_kiosk.GetCart());
            buildPizzaForm.ShowDialog();
            DisplayGridItems();
        }
        private void beverageButton_Click(object sender, EventArgs e)
        {
            this.BeverageSelectFormLoader();
        }
        private void beverageImage_Click(object sender, EventArgs e)
        {
            this.BeverageSelectFormLoader();
        }

        private void BeverageSelectFormLoader()
        {
            var beverageSelectForm = new BeverageForm(this._kiosk.GetCart());
            beverageSelectForm.ShowDialog();
            DisplayGridItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                System.Diagnostics.Debug.WriteLine(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                EditCartItem(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Refresh();
            }
        }

        private void EditCartItem(string itemName)
        {
            var cart = this._kiosk.GetCart();
            cart.RemoveItem(cart.GetItemId(itemName));
            DisplayGridItems();
        }

        private void DisplayGridItems()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            var (cartItems, cartTotal) = this._kiosk.GetCart().GetCartDetails();
            foreach (var el in cartItems)
            {
                this.dataGridView1.Rows.Add(el.Name, el.Quantity, "edit");
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            var checkoutForm = new CheckoutPage(this._kiosk);
            checkoutForm.ShowDialog();
            if (checkoutForm.orderSuccess)
            {
                this.Close();
            }
        }

    }
}
