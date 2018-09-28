using System;

namespace PartyInvites.Models
{
    public class ErrorViewModel
    {
        private string requestId;

        public string RequestId { get; set; }
        

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}