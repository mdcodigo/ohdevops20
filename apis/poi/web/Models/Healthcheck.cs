using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy";
            //Status = "Broken...";
            Version = "v15";
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
