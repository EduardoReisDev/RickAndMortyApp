using System.Collections.Generic;
using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        [JsonProperty("residents")]
        public List<Character> Residents { get; set; }
    }
}
