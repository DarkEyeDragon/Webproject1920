using System;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}