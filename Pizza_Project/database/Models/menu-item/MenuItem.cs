using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.model_helpers;

namespace Pizza_Project.database.Models.menu_item
{
    public class MenuItem : GlobalJSONProperties
    {
        [JsonPropertyName("price")]
        public double Price {get; set;}
        
        [JsonPropertyName("category")]
        public string Category {get; set;}
        
        [JsonPropertyName("instructions")]
        public string Instructions { get; set;}
        
        [JsonPropertyName("ingredientIds")]
        public List<string> IngredientIds { get; set;}
    }
}