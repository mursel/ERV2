using NLog;
using System;

namespace Logger
{
    public class LogService : ILogService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public void Dbg(string msg)
        {
            logger.Debug(msg);
        }

        public void Err(string msg)
        {
            logger.Error(msg);
        }

        public void Info(string msg)
        {
            logger.Info(msg);
        }

        public void Warn(string msg)
        {
            logger.Warn(msg);
        }
    }
}
