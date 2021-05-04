using Bridge_Pattern_Logger.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Loggers
{
    class DetalledLogger : Logger
    {
        public DetalledLogger(IWriter writer) : base(writer)
        { }

        public override void LogError(string message)
        {
            Writer.Write($"Loge type [{LogType.Error}] Date : ({DateTime.Now.ToShortDateString()}  {DateTime.Now.ToLongTimeString()})\nMessage : {message}");
        }

        public override void LogInfo(string message)
        {
            Writer.Write($"Loge type [{LogType.Info}] Date : ({DateTime.Now.ToShortDateString()}  {DateTime.Now.ToLongTimeString()})\nMessage : {message}");
        }

        public override void LogWarning(string message)
        {
            Writer.Write($"Loge type [{LogType.Warning}]  Date : ({DateTime.Now.ToShortDateString()}  {DateTime.Now.ToLongTimeString()})\nMessage : {message}");
        }
    }
}
