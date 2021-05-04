using System;

namespace Abstract_Factory_Animal
{
    public class EurasiaFactory : ContinentFactory
    {
        public override Herbivore CreatHerbivore()
        {
            return new Elk() { Weight = Random.Next(140, 170) };
        }

        public override Predator CreatPredator()
        {
            return new Tiger() { Power = Random.Next(160, 200) };
        }
    }
}
