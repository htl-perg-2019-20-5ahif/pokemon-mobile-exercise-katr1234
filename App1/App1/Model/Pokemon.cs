using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace App1.Model
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("front_default")]
        public string FrontUrl { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("ability")]
        public List<Ability> Abilities { get; set; }

        [JsonPropertyName("back_default")]
        public int BackUrl { get; set; }
    }
}
