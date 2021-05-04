using Bridge_Pattern_Logger.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Loggers
{
    class SimpleLogger : Logger
    {
        public SimpleLogger(IWriter writer) : base(writer){ }

        public override void LogError(string message)
        {
            Writer.Write($"Type [{LogType.Error}]\nMessage : " + message);
        }

        public override void LogInfo(string message)
        {
            Writer.Write($"Type [{LogType.Error}]\nMessage : " + message);
        }

        public override void LogWarning(string message)
        {
            Writer.Write($"Type [{LogType.Error}]\nMessage : " + message);
        }
    }
}
