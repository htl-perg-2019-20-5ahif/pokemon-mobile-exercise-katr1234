using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace App1.Model
{
    public class Ability
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
