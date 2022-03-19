using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RickAndMorty.Models
{
    public class FilterCharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Species { get; set; }

        [JsonProperty("name")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Gender { get; set; }

        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;
                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }

            return d;
        }
    }
}
