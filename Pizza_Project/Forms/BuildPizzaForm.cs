using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.database.controllers.data_controllers.menu_controllers;
using Pizza_Project.kiosk;

namespace Pizza_Project.Forms
{
    public partial class BuildPizzaForm : Form
    {

        private MenuIngredientController _menuIngredientController;
        private Cart _cart;

        private List<string> ingredientIds = new List<string>();

        public BuildPizzaForm(Cart cart)
        {
            InitializeComponent();
            this._menuIngredientController = new MenuIngredientController();
            this._cart = cart;
        }

        private void BuildPizzaForm_Load(object sender, EventArgs e)
        {
            this.thinCheckbox.Checked = true;
            this.sizeSmallCheckbox.Checked = true;
            this.baseCheeseCheckbox.Checked = true;
            this.baseSauceCheckbox.Checked = true;
        }

        private string GetNameFromCheckbox(string name)
        {
            return name.Split(" +")[0];
        }

        private void CheckBoxChecked(CheckBox checkbox)
        {
            var ingredient = _menuIngredientController.GetItemByName(GetNameFromCheckbox(checkbox.Text));
        
            if (checkbox.Checked)
            {
                this.ingredientIds.Add(ingredient.Id);
                return;
            }

            this.ingredientIds.RemoveAt(this.ingredientIds.IndexOf(ingredient.Id));
        }

        private void thinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.thinCheckbox);
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            this._cart.AddItem(this.ingredientIds, Decimal.ToInt32(this.qtyNumericCounter.Value), "Pizza");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void handTossedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.handTossedCheckbox);
        }

        private void brooklynStyleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.brooklynStyleCheckbox);
        }

        private void sizeSmallCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.sizeSmallCheckbox);
        }

        private void sizeMediumCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.sizeMediumCheckbox);
        }

        private void sizeLargeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.sizeLargeCheckbox);
        }

        private void sizeXLCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.sizeXLCheckbox);
        }

        private void baseCheeseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.baseCheeseCheckbox);
        }

        private void baseSauceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.baseSauceCheckbox);
        }

        private void meatPepCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.meatPepCheckbox);
        }

        private void meatSausageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.meatSausageCheckbox);
        }

        private void meatAnchovyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.meatAnchovyCheckbox);
        }

        private void vegOnionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.vegOnionCheckbox);
        }

        private void vegMushroomCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.vegMushroomCheckbox);
        }

        private void vegBOliveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.vegBOliveCheckbox);
        }

        private void vegGOliveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.vegGOliveCheckbox);
        }

        private void vegSpinachCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.vegSpinachCheckbox);
        }

        private void fruitPineappleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(this.fruitPineappleCheckbox);
        }
    }
}
