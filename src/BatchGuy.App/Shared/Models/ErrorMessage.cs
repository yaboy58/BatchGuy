using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Models
{
    public class ErrorMessage
    {
        public string DisplayMessage { get; set; }
        public string DisplayTitle { get; set; }
        public string ExceptionMessage { get; set; }
        public string MethodNameWhereExceptionOccurred { get; set; }
    }
}
