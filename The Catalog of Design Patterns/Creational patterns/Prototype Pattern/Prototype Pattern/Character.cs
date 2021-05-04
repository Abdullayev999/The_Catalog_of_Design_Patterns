using System;

namespace Prototype_Pattern
{
    class Character : ICloneable
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intellect { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("\nStats: ");
            Console.WriteLine($"Health points: {HP}");
            Console.WriteLine($"Mana points: {MP}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Intellect: {Intellect}");
        }
    }
}
