

using Newtonsoft.Json;
using System.Collections.Generic;

namespace WorkPlaceConnector.Models
{
    public class GraphCollection<T>
    {
        [JsonProperty("value")]
        public List<T> Items { get; set; }
    }
}