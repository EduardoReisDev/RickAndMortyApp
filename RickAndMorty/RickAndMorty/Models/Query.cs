using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Query
    {
        [JsonProperty("character")]
        public Character Character { get; set; }

        [JsonProperty("characters")]
        public Characters Characters { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("locations")]
        public Locations Locations { get; set; }
    }
}
