using NLog;
using System;

namespace m13010203.Logger
{
    public class NLogger : Common.ILogger
    {
        private static readonly NLog.ILogger Logger = LogManager.GetLogger("Logger");

        public void LogError(Exception exception, string message)
        {
            Logger.Error(exception, message);
        }

        public void LogInfo(string message)
        {
            Logger.Info(message);
        }

        public void LogDebug(string message)
        {
            Logger.Debug(message);
        }
    }
}
