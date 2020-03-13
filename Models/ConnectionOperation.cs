

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkPlaceConnector.Models
{
    public enum ConnectionOperationStatus
    {
        Unspecified,
        InProgress,
        Completed,
        Failed
    }
    public class ConnectionOperation
    {
        public ErrorDetail Error {get; set; }
        public string Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ConnectionOperationStatus Status { get; set; }
    }
}