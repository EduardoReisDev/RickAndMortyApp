using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Info
    {
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("pages")]
        public int? Pages { get; set; }

        [JsonProperty("next")]
        public int? Next { get; set; }

        [JsonProperty("prev")]
        public int? Prev { get; set; }
    }
}
