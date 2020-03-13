

using System.Collections.Generic;

namespace WorkPlaceConnector.Models
{
    public class ErrorDetail
    {
        public List<InnerErrorDetail> Details { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
}