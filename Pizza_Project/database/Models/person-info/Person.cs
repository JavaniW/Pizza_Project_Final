using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pizza_Project.database.Models.model_helpers;

namespace Pizza_Project.database.Models.person_info { 

    public class Person : GlobalJSONProperties
    {
        [JsonPropertyName("email")]
        public string Email {get; set;}
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber {get; set;}
        [JsonPropertyName("userAddress")]
        public PersonAddress UserAddresses {get; set;}
        
    }
}