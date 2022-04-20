using System.Collections.Generic;
using System.Linq;
using Pizza_Project.database.controllers.data_controllers.abstract_classes;
using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.Models.menu_item;

namespace Pizza_Project.database.controllers.data_controllers.menu_controllers
{
    public class MenuItemController : AbstractMenu<MenuItem>
    {
        /// <summary>
        /// Gets the total price of an item.
        /// </summary>
        /// <param name="initPrice">Initial price of food item</param>
        /// <param name="ingredients">Ingredient Ids</param>
        /// <returns>Total item price.</returns>
        public double GetFinalPrice(double initPrice, List<string> ingredients)
        {
            var finalPrice = initPrice;

            var ingredientController = new MenuIngredientController();
            var ingredientList = ingredientController.Read();

            foreach (var ingredient in ingredients)
            {
                foreach (var listIngredient in ingredientList)
                {
                    if (ingredient.Equals(listIngredient.Id))
                    {
                        finalPrice += listIngredient.Price;
                    }
                }
            }

            return finalPrice;
        }
        
        public override List<MenuItem> Read()
        {
            var data = GetAllData();
            return new List<MenuItem>(data.Menu.MenuItems);
        }

        public override void Update(List<MenuItem> list)
        {
            var data = GetAllData();
            data.Menu.MenuItems = list;
            DatabaseHandler.Write(data);
        }
    }
}