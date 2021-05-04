using System;

namespace Abstract_Factory_Animal
{
    /*
     Абстрактная фабрика — это порождающий паттерн проектирования, 
    который позволяет создавать семейства связанных объектов, 
    не привязываясь к конкретным классам создаваемых объектов.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Land land = new Land();
            land.AnimalCreator = new AfricaFactory();

            
            land.AddPredator();
            land.AddPredator();
            land.AddHerbivore();
            land.AddHerbivore();

            land.AnimalCreator = new EurasiaFactory();


            land.AddPredator();
            land.AddPredator();
            land.AddHerbivore();
            land.AddHerbivore();
            land.AddHerbivore();

            land.AnimalCreator = new NorthAmericaFactory();


            land.AddPredator();
            land.AddPredator();
            land.AddHerbivore();
            land.AddHerbivore();
            land.AddHerbivore();


            Console.WriteLine("-----------------------------------------------------");
            land.AnimalStatus();
            Console.WriteLine("-----------------------------------------------------");
            land.EatHerbivore();
            land.HuntPredator();           
            Console.WriteLine("-----------------------------------------------------");
            land.AnimalStatus();
            Console.WriteLine("-----------------------------------------------------");
            

        }
    }
}
