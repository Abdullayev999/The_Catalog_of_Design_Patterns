using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Service
{
    class FileWriter : IWriter
    {
        private readonly string filePath;

        public FileWriter(string filePath = "defaultPath.txt")
        {
            this.filePath = filePath;
        }
        public void Write(string text)
        {
            File.AppendAllText(filePath, text + "\n\n");
        }
    }
}
