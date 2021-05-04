using System;
using System.Collections.Generic;

namespace Abstract_Factory_Animal
{
    public class Land
    {
        public Random Random { get; set; } = new Random();
        public ContinentFactory AnimalCreator { get; set; } = new NorthAmericaFactory();
        public List<Animal> animals = new List<Animal>();

        public void AddHerbivore()
        {
            animals.Add(AnimalCreator.CreatHerbivore());
        }

        public void AddPredator()
        {
            animals.Add(AnimalCreator.CreatPredator());
        }

        public void EatHerbivore()
        {
            foreach (var animal in animals)
            {
                if (animal is Herbivore herbivore)
                {
                    herbivore.Eating();
                }
            }
        }

        public void HuntPredator()
        {
            for (int i = 0 , j = 0; i < animals.Count; i++)
            {
                if (animals[i] is Predator animal)
                {
                    for (; j < animals.Count; j++)
                    {
                        if (animals[j] is Herbivore herbivore && herbivore.isLive)
                        {
                            animal.Hunting(herbivore);
                            break;
                        }
                    }
                }
            }

            BalanceAnimal();            
           // DeleteDeathAnimal();
        }

        // zakamentirovana na 208 strocki dlya unictojenie mertvix jivotnix
        private void DeleteDeathAnimal()
        {
            List<int> deleteIndex = new List<int>();

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] is Herbivore herbivore && !herbivore.isLive)
                {
                    deleteIndex.Add(i);
                }
            }

            for (int i = 0; i < deleteIndex.Count; i++)
            {
                int index = deleteIndex.Count - 1 - i;
                animals.RemoveAt(deleteIndex[index]);
            }
        }

        private void BalanceAnimal()
        {
            //dlya podderjivanie balansa jivotnix,ctob xiwniki ne qolodali
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    AnimalCreator = new AfricaFactory();
                else if (i == 1)
                    AnimalCreator = new EurasiaFactory();
                else if (i == 2)
                    AnimalCreator = new NorthAmericaFactory();

                animals.Add(AnimalCreator.CreatHerbivore());
            }
        }

        public void AnimalStatus()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
