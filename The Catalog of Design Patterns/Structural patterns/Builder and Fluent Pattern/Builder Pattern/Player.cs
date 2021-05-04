using System;

namespace Builder_Pattern
{
    class Player
    {
        ////BAD CODE! Too many params in constructor.
        //public Player(string name, Weapon rightHand, Weapon leftHand, Armor head, Armor chest, Armor legs)
        //{
        //    Name = name;
        //    RightHand = rightHand;
        //    LeftHand = leftHand;
        //    Head = head;
        //    Chest = chest;
        //    Legs = legs;
        //}


        public string Name { get; set; }
        public Weapon RightHand { get; set; }
        public Weapon LeftHand { get; set; }
        public Armor Head { get; set; }
        public Armor Chest { get; set; }
        public Armor Legs { get; set; }
         

        public void Info()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Player name: {Name}");
            Console.WriteLine($"\nPlayer equipment:");
            Console.WriteLine($"Right hand: {RightHand?.ToString() ?? "None"}");
            Console.WriteLine($"Left hand: {LeftHand?.ToString() ?? "None"}");
            Console.WriteLine($"Head: {Head?.ToString() ?? "None"}");
            Console.WriteLine($"Chest: {Chest?.ToString() ?? "None"}");
            Console.WriteLine($"Legs: {Legs?.ToString() ?? "None"}");
            Console.WriteLine($"\nPlayer stats:");
            Console.WriteLine($"Damage: {(RightHand?.Damage ?? 0) + (LeftHand?.Damage ?? 0)}");
            Console.WriteLine(
                $"Defense: {(RightHand?.Defense ?? 0) + (LeftHand?.Defense ?? 0) + (Head?.Defense ?? 0) + (Chest?.Defense ?? 0) + (Legs?.Defense ?? 0)}");
            Console.WriteLine("-----------------------\n");
        }
    }
}