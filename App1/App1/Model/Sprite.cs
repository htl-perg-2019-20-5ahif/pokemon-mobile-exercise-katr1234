using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace App1.Model
{
    public class Sprite
    {
        [JsonPropertyName("front_default")]
        public Uri FrontUrl { get; set; }

        [JsonPropertyName("back_default")]
        public Uri BackUrl { get; set; }
    }
}
