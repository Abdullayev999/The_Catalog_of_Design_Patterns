using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Engine
    {
        public int CountPiston { get; set; }
        public int HorsePower { get; set; }
    }

    public enum EngineType { R4, V6, V8 };
}
