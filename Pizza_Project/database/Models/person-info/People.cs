using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.user_info;
using Pizza_Project.database.Models.customer_info;

namespace Pizza_Project.database.Models.person_info
{
    public class People
    {
        [JsonPropertyName("customers")]
        public IList<Customer> Customers {get; set;}
        [JsonPropertyName("users")]
        public IList<User> Users {get; set;}        
    }
}