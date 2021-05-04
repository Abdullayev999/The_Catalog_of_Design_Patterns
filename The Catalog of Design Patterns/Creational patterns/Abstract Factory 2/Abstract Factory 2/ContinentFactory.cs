using System;

namespace Abstract_Factory_Animal
{
    public abstract class ContinentFactory
    {
        // dlyarandomnix xarakteristik
        public Random Random { get; set; } = new Random();
        public abstract Herbivore CreatHerbivore();
        public abstract Predator CreatPredator();
    }
}
