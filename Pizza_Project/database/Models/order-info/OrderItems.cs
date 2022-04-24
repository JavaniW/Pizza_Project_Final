using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.menu_item;
using Pizza_Project.database.Models.model_helpers;

namespace Pizza_Project.database.Models.order_info
{
    public class OrderItems : GlobalJSONProperties
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        
        [JsonPropertyName("ingredients")]
        public List<string> Ingredients { get; set; }
        
        [JsonPropertyName("itemTotal")]
        public double ItemTotal { get; set; }

        public string ingredientsWrite()
        {
            string listOfIngredients = "";
            foreach (string ingred in Ingredients)
            {
                listOfIngredients += ingred + "\n";
            }
            return listOfIngredients;
        }
    }
}