using System;
using System.Collections.Generic;

namespace Memento_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerSaves playerSaves = new PlayerSaves(player);

            player.Info();

            player.Attack();
            player.TakeDamage(10);
            player.Move(Direction.Right);
            player.Info();

            playerSaves.SavePlayer();

            player.Attack();
            player.Attack();
            player.Attack();
            player.TakeDamage(15);
            player.Move(Direction.Down);
            player.Info();

            playerSaves.LoadPlayer();

            player.Info();
        }
    }

    class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    enum Direction
    {
        Up, Down, Left, Right
    }

    class Player
    {
        public int HP { get; set; } = 100;
        public int Stamina { get; set; } = 100;
        public Location Location { get; set; }

        public Player()
        {
            Location  = new Location { X = 0, Y = 0 };
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Location.Y--;
                    break;
                case Direction.Down:
                    Location.Y++;
                    break;
                case Direction.Left:
                    Location.X--;
                    break;
                case Direction.Right:
                    Location.X++;
                    break;
                default:
                    break;
            }
        }

        public void Attack()
        {
            Stamina -= 5;
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }

        public PlayerMemento Save()
        {
            return new PlayerMemento(HP, Stamina, Location);
        }

        public void Load(PlayerMemento memento)
        {
            HP = memento.HP;
            Stamina = memento.Stamina;
            Location = memento.Location;
        }

        public void Info()
        {
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Stamina: {Stamina}");
            Console.WriteLine($"Location: {Location.X} - {Location.Y}");
            Console.WriteLine();
        }
    }

    class PlayerMemento
    {
        public PlayerMemento(int hp, int stamina, Location location)
        {
            HP = hp;
            Stamina = stamina;
            Location = location;
        }

        public int HP { get; set; }
        public int Stamina { get; set; }
        public Location Location { get; set; }
    }

    class PlayerSaves
    {
        private Player player;
        private Stack<PlayerMemento> saves;

        public PlayerSaves(Player player)
        {
            this.player = player;
            saves = new Stack<PlayerMemento>();
        }


        public void SavePlayer()
        {
            var memento = player.Save();
            saves.Push(memento);
        }

        public void LoadPlayer()
        {
            var memento = saves.Pop();
            player.Load(memento);
        }
    }
}
