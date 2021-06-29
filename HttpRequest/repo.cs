using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HttpRequest
{
    public class Repository
    { 
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("name")]
        public string TargetMachineID { get; set; }
        [JsonPropertyName("mid")]
        public float Rate { get; set; }
    }
}
