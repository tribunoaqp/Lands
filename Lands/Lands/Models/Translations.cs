﻿namespace Lands.Models
{
    using Newtonsoft.Json;
    public class Translations
    {
        [JsonProperty(PropertyName = "de")]
        public string Germany { get; set; }
        [JsonProperty(PropertyName = "es")]
        public string Spanish { get; set; }
        [JsonProperty(PropertyName = "fr")]
        public string French { get; set; }
        [JsonProperty(PropertyName = "ja")]
        public string Japanese { get; set; }
        [JsonProperty(PropertyName = "it")]
        public string Italian { get; set; }
        [JsonProperty(PropertyName = "br")]
        public string Brasilian { get; set; }
        [JsonProperty(PropertyName = "pt")]
        public string Portugues { get; set; }
        [JsonProperty(PropertyName = "nl")]
        public string Dutch { get; set; }
        [JsonProperty(PropertyName = "hr")]
        public string Croacian { get; set; }
        [JsonProperty(PropertyName = "fa")]
        public string Persian { get; set; }

    }
}
