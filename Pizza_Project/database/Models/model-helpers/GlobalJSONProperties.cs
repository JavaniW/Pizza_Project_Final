using System.Text.Json.Serialization;

namespace Pizza_Project.database.Models.model_helpers
{
    public class GlobalJSONProperties
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}