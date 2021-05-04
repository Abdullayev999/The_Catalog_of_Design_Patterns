using System;

namespace Abstract_Factory_Animal
{
    public abstract class Herbivore  : Animal 
    {
        // dlya raznobrazii sil jivotnix
        public Random random = new Random();
        public int Weight { get; set; }
        public bool isLive { get; set; } = true;
        public abstract void Eating();
    }
}
