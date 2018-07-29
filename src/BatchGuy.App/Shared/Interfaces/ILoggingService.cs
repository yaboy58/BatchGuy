using System;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface ILoggingService
    {
        void LogErrorFormat(Exception exception, string methodName);
    }
}
