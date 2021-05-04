using System;

namespace Abstract_Factory_Animal
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreatHerbivore()
        {
            return new Bison() { Weight = Random.Next(150,200) };
        }

        public override Predator CreatPredator()
        {
            return new Lion() { Power = Random.Next(180, 240) };
        }
    }
}
