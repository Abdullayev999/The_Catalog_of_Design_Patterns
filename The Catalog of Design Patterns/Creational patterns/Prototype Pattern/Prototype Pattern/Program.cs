using System;
using System.Collections.Generic;

namespace Prototype_Pattern
{
    enum CharacterClass { Warrior = 1, Thief, Mage }

    class Program
    {
        static void Main(string[] args)
        {
            CharacterManager characterManager = new CharacterManager();
            Character character;

            while (true)
            {
                Console.WriteLine("Choose your class :\n1 - Warrior\n2 - Theif\n3 - Mage\n");
                Enum.TryParse(Console.ReadKey().KeyChar.ToString(), out CharacterClass classChoise);
                try
                {
                    character = characterManager[classChoise];
                    Console.Clear();
                    break;
                }
                catch (KeyNotFoundException)
                {
                    Console.Clear();
                }
            }

            while (true)
            {
                Console.Write("Write your name: ");
                character.Name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(character.Name))
                {
                    Console.Clear();
                    Console.WriteLine("Name can't be empty!");
                }
                else break;
            }


            int additionalPoints = 3;
            while (additionalPoints != 0)
            {
                Console.Clear();
                character.Info();
                Console.WriteLine($"\nYou have {additionalPoints} additional points!");
                Console.Write("Choose stat to improve (1 - STR, 2 - DEX, 3 - INT): ");
                Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int skillChoise);
                switch (skillChoise)
                {
                    case 1:
                        character.Strength++;
                        additionalPoints--;
                        break;
                    case 2:
                        character.Dexterity++;
                        additionalPoints--;
                        break;
                    case 3:
                        character.Intellect++;
                        additionalPoints--;
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Your character has been created!\n");
            character.Info();
        }
    }
}
