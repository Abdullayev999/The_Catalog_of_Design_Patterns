using System;

namespace Abstract_Factory_Animal
{
    public class NorthAmericaFactory : ContinentFactory
    {

        public override Herbivore CreatHerbivore()
        {
            return new Antelope() { Weight = Random.Next(50 , 80) };
        }

        public override Predator CreatPredator()
        {
            return new Wolf() { Power = Random.Next(70 , 100) };
        }
    }
}
