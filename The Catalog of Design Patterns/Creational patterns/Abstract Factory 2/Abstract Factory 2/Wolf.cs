﻿namespace Abstract_Factory_Animal
{
    public class Wolf : Predator
    {
        public override void Hunting(Herbivore herbivore)
        {
            if (herbivore.Weight < Power)
            {
                herbivore.isLive = false;
                Power += 10;
            }
            else
            {
                Power -= 10;
            }
        }
        public override string ToString()
        {
            return $"Wolf Power : {Power} (Predator)";
        }
    }
}
