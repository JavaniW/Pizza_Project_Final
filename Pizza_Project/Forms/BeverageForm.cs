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
using Pizza_Project.database.Models.menu_item;
using Pizza_Project.kiosk;

namespace Pizza_Project.Forms
{
    public partial class BeverageForm : Form
    {
        private readonly MenuIngredientController _menuIngredientController;
        private readonly Cart _cart;

        private List<MenuIngredient> SelectedItems;
        private List<string> SelectedItemIds;

        private List<MenuIngredient> drinks;
        private List<MenuIngredient> sizes;
        private int Quantity;

        public BeverageForm(Cart cart)
        {
            InitializeComponent();

            this._menuIngredientController = new MenuIngredientController();
            this._cart = cart;
            this.SelectedItems = new List<MenuIngredient>();
            this.SelectedItemIds = new List<string>();
            this.drinks = new List<MenuIngredient>();
            this.sizes = new List<MenuIngredient>();
            this.Quantity = 0;

            foreach (var item in this._menuIngredientController.Read())
            {
                if (item.Category.Equals("beverage-size"))
                {
                    this.sizes.Add(item);
                }else if (item.Category.Equals("beverage"))
                {
                    this.drinks.Add(item);
                }else
                {
                    continue;
                }
            }
        }

        private void BeverageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            if (ValidateUserSelection() == false || this.SelectedItemIds.Count != 2) {
                this.errorLabel.Text = "Invalid Beverage Selection.";
                return;
            }

                System.Diagnostics.Debug.WriteLine(this.SelectedItemIds.Count);
            foreach (var item in this.SelectedItems)
            {
                if (this.SelectedItemIds.Contains(item.Id))
                {
                    continue;
                }
                this.SelectedItemIds.Add(item.Id);

            }
            System.Diagnostics.Debug.WriteLine("here" + this.SelectedItemIds.Count);

            this._cart.AddItem(this.SelectedItemIds, Decimal.ToInt32(this.qtyNumericCounter.Value), "Beverage");
            this.Close();
        }

        /// <summary>
        /// validates that only one drink and one size are selected
        /// </summary>
        /// <returns>true if list is valid</returns>
        private bool ValidateUserSelection()
        {
            var sizeCount = 0;
            var bevCount = 0;
            foreach (var item in this.SelectedItems)
            {
                if (item.Category.Equals("beverage-size"))
                {
                    sizeCount++;
                }
                else if (item.Category.Equals("beverage"))
                {
                    bevCount++;
                }
            }
            if (bevCount == 1 && sizeCount == 1) return true;

            return false;
        }

        private string GetNameFromCheckbox(string name)
        {
            if (name.Contains("+")) return name.Split(" +")[0];
            return name;
        }

        private void CheckBoxChecked(CheckBox checkbox)
        {
            var ingredient = _menuIngredientController.GetItemByName(GetNameFromCheckbox(checkbox.Text) + " Beverage");
            if (checkbox.Checked)
            {
                this.SelectedItemIds.Add(ingredient.Id);
                this.SelectedItems.Add(ingredient);
                return;
            }

            this.SelectedItemIds.RemoveAt(this.SelectedItemIds.IndexOf(ingredient.Id));

            var itemToRemove = this.SelectedItems.Find(e => e.Id.Equals(ingredient.Id));

            this.SelectedItems.Remove(itemToRemove);
        }

        private void smallCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.smallCheckbox);
        }

        private void mediumCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.mediumCheckbox);
        }

        private void largeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.largeCheckbox);
        }

        private void cokeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.cokeCheckbox);
        }

        private void spriteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.spriteCheckbox);
        }

        private void pepsiCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.pepsiCheckbox);
        }

        private void sweetTeaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.sweetTeaCheckbox);
        }

        private void unsweetTeaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBoxChecked(this.unsweetTeaCheckbox);
        }

        private void qtyNumericCounter_ValueChanged(object sender, EventArgs e)
        {
            this.Quantity = (int) this.qtyNumericCounter.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
