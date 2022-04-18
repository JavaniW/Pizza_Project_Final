using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pizza_Project.database.Models.order_info
{
    public class OrderItems
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        
        [JsonPropertyName("ingredientIds")]
        public IList<string> IngredientIds { get; set; }
        
        [JsonPropertyName("itemTotal")]
        public double ItemTotal { get; set; }
    }
}