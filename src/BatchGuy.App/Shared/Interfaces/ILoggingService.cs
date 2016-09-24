using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface ILoggingService
    {
        void LogErrorFormat(Exception exception, string methodName);
    }
}
