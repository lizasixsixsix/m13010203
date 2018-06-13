using System;

namespace m13010203.Common
{
    public interface ILogger
    {
        void LogError(Exception exception, string message);

        void LogInfo(string message);

        void LogDebug(string message);
    }
}
