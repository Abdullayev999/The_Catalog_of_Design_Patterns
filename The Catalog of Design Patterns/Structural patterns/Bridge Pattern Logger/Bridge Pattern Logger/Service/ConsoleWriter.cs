using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Service
{
    class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text+"\n");
        }
    }
}
