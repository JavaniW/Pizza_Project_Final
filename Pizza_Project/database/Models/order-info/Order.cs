using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.menu_item;

namespace Pizza_Project.database.Models.order_info
{
    public class Order
    {
        [JsonPropertyName("orderNumber")]
        public int OrderNumber {get;set;}
        
        [JsonPropertyName("orderName")]
        public string OrderName {get;set;}
        
        [JsonPropertyName("orderTotal")]
        public double OrderTotal {get;set;}
        
        [JsonPropertyName("items")]
        public IList<OrderItems> Items {get; set;}
    }
}