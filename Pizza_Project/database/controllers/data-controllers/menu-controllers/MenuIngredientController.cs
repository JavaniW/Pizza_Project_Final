using System.Collections.Generic;
using Pizza_Project.database.controllers.data_controllers.abstract_classes;
using Pizza_Project.database.controllers.file_handler;
using Pizza_Project.database.Models.menu_item;

namespace Pizza_Project.database.controllers.data_controllers.menu_controllers
{
    public class MenuIngredientController : AbstractMenu<MenuIngredient>
    {
        public override List<MenuIngredient> Read()
        {
            var data = GetAllData();
            return new List<MenuIngredient>(data.Menu.Ingredients);
        }

        public override void Update(List<MenuIngredient> list)
        {
            var data = GetAllData();
            data.Menu.Ingredients = list;
            DatabaseHandler.Write(data);
        }

        public double GetIngredientPrice(List<string> ingredientIds)
        {
            double finalPrice = 0;
            var ingredientList = this.Read();

            foreach (var ingredient in ingredientIds)
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
    }
}