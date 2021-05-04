using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern_Logger.Service
{
    public interface IWriter
    {
        void Write(string text);
    }
}
