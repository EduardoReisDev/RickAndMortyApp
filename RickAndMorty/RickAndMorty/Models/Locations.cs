using System.Collections.Generic;
using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Locations
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Location> Results { get; set; }
    }
}
