using System.Text.Json.Serialization;
using Pizza_Project.database.Models.model_helpers;

namespace Pizza_Project.database.Models.menu_item
{
    public class MenuIngredient : GlobalJSONProperties
    {
        [JsonPropertyName("category")]
        public string Category {get;set;}
        
        [JsonPropertyName("price")]
        public double Price {get;set;}
    }
}