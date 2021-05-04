using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine Engine { get; set; }
        public GearBox GearBox { get; set; }
    }
}
