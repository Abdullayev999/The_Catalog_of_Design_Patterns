using Bridge_Pattern_Logger.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Loggers
{
    public abstract class Logger
    {
        protected IWriter Writer;

        public Logger(IWriter writer)
        {
            this.Writer = writer;
        }
        public abstract void LogInfo(string message);
        public abstract void LogWarning(string message);
        public abstract void LogError(string message);
    }
}
