using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace App1.Model
{
    public class PokemonDetails
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        public AbilitySlot[] Abilities { get; set; }
        public Sprite Sprites { get; set; }
    }
}
