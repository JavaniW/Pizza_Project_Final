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

        }

        private string GetNameFromCheckbox(string name)
        {
            return name.Split(" ")[0];
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
