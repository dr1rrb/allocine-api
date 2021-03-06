﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AlloCine
{
    [DataContract]
    public class T
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("p")]
        public int P { get; set; }

        [JsonPropertyName("$")]
        public string Value { get; set; }
    }
}