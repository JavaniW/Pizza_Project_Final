using System.Text.Json.Serialization;
using Pizza_Project.database.Models.person_info;

namespace Pizza_Project.database.Models.user_info
{
    public class User : Person
    {
        [JsonPropertyName("password")]
        public string Password {get; set;}
        
        [JsonPropertyName("role")]
        public string Role {get; set;}
    }
}