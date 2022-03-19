using System.Collections.Generic;
using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Characters
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Character> Results { get; set; }
    }
}
