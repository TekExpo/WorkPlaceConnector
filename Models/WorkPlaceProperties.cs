

using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace WorkPlaceConnector.Models
{
    public class WorkPlaceProperties
    {
        public int PostId { get; set; }
        public string PostedBy { get; set; }
        public string description { get; set; }
        public DateTime PostedOn { get; set; }
        public string URL { get; set; }
       /* [JsonProperty("appliances@odata.type")]
        private const string AppliancesODataType = "Collection(String)";
        public List<string> Appliances { get; set; }*/
    }
}