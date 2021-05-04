using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCalculetor calculetor = new CarCalculetor();
            Console.WriteLine($"car price: {calculetor.CalculetPrice("BMW", "M5", 2016, EngineType.V6, GearType.Automatic)}$");
            Console.WriteLine($"car price: {calculetor.CalculetPrice("Toyota", "Avensis", 2003, EngineType.R4, GearType.Mechanic)}$");
        }
    }
}
