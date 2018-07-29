using System;

namespace BatchGuy.App.Shared.Models
{
    public class ErrorMessage
    {
        public string DisplayMessage { get; set; }
        public string DisplayTitle { get; set; }
        public Exception Exception { get; set; }
        public string MethodNameWhereExceptionOccurred { get; set; }
    }
}
