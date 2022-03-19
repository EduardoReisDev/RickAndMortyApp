using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("origin")]
        public Location Origin { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        public string StatusImage
        {
            get
            {
                string imageName = string.Empty;

                switch (Status)
                {
                    case "Alive":
                        imageName = "alive.png";
                        break;

                    case "unknown":
                        imageName = "unknown.png";
                        break;

                    case "Dead":
                        imageName = "dead.png";
                        break;
                }

                return imageName;
            }
        }
    }
}
