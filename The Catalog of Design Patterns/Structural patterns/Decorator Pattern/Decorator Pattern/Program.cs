using System;

namespace Decorator_Pattern
{
    //Component
    abstract class Weapon
    {
        public virtual int Accuracy { get; set; }
        public virtual int Damage { get; set; }
        public virtual int Capacity { get; set; }

        public void Info()
        {
            Console.WriteLine($"Accuracy: {Accuracy}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine();
        }
    }

    //ConcreteComponent
    class M16 : Weapon
    {
        public M16()
        {
            Accuracy = 5;
            Damage = 5;
            Capacity = 30;
        }
    }

    //Decorator
    abstract class Upgrade : Weapon
    {
        Weapon weapon = null;

        private int accuracy;
        private int damage;
        private int capacity;

        public override int Accuracy
        {
            get => weapon.Accuracy + accuracy;
            set => accuracy = value;
        }

        public override int Damage
        {
            get => weapon.Damage + damage;
            set => damage = value;
        }

        public override int Capacity
        {
            get => weapon.Capacity + capacity;
            set => capacity = value;
        }

        public Weapon SetUpgrade(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public Weapon RemoveUpgrade()
        {
            return weapon;
        }
    }

    //ConcreteDecorator
    class Scope : Upgrade
    {
        public Scope()
        {
            Accuracy = 15;
        }
    }

    //ConcreteDecorator
    class Suppressor : Upgrade
    {
        public Suppressor()
        {
            Accuracy = 5;
            Damage = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new M16();
            weapon.Info();

            Upgrade upgrade = new Scope();
            weapon = upgrade.SetUpgrade(weapon);
            weapon.Info();

            Upgrade upgrade2 = new Suppressor();
            weapon = upgrade2.SetUpgrade(weapon);
            weapon.Info();

            if (weapon is Upgrade)
            {
                weapon = (weapon as Upgrade).RemoveUpgrade();
                weapon.Info();
            }
        }
    }
}
