using System;
using System.Collections.Generic;

namespace Factory_Method_Pattern
{
    abstract class Wizzard
    {
        public int MP { get; set; }
        public  List<Spell> Spells { get; set; }

        public Wizzard()
        {
            Spells = new List<Spell>();
        }

        public void Info()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Mana points: {MP}");
            Console.WriteLine("\nSpells list:");
            
            foreach (var item in Spells)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------\n");
        }
    }
}