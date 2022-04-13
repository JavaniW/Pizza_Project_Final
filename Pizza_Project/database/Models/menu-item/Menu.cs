using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pizza_Project.database.Models.menu_item
{
    public class Menu
    {
        [JsonPropertyName("menuItems")]
        public IList<MenuItem> MenuItems {get; set;}
        
        [JsonPropertyName("ingredients")]
        public IList<MenuIngredient> Ingredients {get; set;}
    }
}