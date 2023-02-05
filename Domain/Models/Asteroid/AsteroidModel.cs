using System.Text.Json.Serialization;

namespace NasaAPI.Models.Asteroids
{
    public class AsteroidModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
    }
}
