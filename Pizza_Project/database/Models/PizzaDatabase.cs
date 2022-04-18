using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.menu_item;
using Pizza_Project.database.Models.order_info;
using Pizza_Project.database.Models.person_info;

namespace Pizza_Project.database.Models
{
    public class PizzaDatabase
    {
        [JsonPropertyName("people")]
        public People People {get; set;}
        [JsonPropertyName("menu")]
        public Menu Menu {get; set;}
    }
}