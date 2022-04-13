using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.model_helpers;

namespace Pizza_Project.database.Models.menu_item
{
    public class MenuItem : GlobalJSONProperties
    {
        [JsonPropertyName("initPrice")]
        public double InitPrice {get; set;}
        
        [JsonPropertyName("finalPrice")]
        public double FinalPrice {get; set;}
        
        [JsonPropertyName("category")]
        public string Category {get; set;}
        
        [JsonPropertyName("instructions")]
        public string Instructions { get; set;}
        
        [JsonPropertyName("ingredientIds")]
        public IList<string> IngredientIds { get; set;}
    }
}