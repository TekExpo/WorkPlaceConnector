

using Newtonsoft.Json;
using System.Collections.Generic;

namespace WorkPlaceConnector.Models
{
    public class ExternalItem {
        [JsonProperty("@odata.type")]
        private const string oDataType = "microsoft.graph.externalItem";
        public string Id { get; set; }
        public object Content { get; set; }
        public List<Acl> Acl { get; set; }
        public object Properties { get; set; }
    }
}