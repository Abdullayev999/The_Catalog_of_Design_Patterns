using Bridge_Pattern_Logger.Loggers;
using Bridge_Pattern_Logger.Service;
using System;
using System.IO;

namespace Bridge_Pattern_Logger
{
   public enum LogType
    {
        Info,Warning,Error
    }
    class Program
    {
        static void Main(string[] args)
        {
            DetalledLogger detalledLogger = new DetalledLogger(new ConsoleWriter());
            //DetalledLogger detalledLogger = new DetalledLogger(new FileWriter("simpleLogger"));

            string file = "text.txt";
            try
            {
                detalledLogger.LogInfo("Read file " + file);
                File.ReadAllText(file); 
            }
            catch (Exception ex)
            {
                detalledLogger.LogError(ex?.StackTrace.Substring(ex.StackTrace.IndexOf("line"))+" : "+ex.Message);
            }


            //---------------------------------------------------------------------------------------

            SimpleLogger simpleLogger = new SimpleLogger(new ConsoleWriter());
            //SimpleLogger simpleLogger = new SimpleLogger(new FileWriter("simpleLogger.txt"));

            try
            {
                simpleLogger.LogInfo("Read file " + file);
                File.ReadAllText(file);
            }
            catch (Exception ex)
            {
                simpleLogger.LogError(ex.Message);
            }
        }
    }
}
