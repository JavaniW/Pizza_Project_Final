using System.Text.Json.Serialization;

namespace Pizza_Project.database.Models.person_info { 

    public class PersonAddress
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }
        [JsonPropertyName("extraInformation")]
        public string ExtraInformation { get; set; }
    }
}