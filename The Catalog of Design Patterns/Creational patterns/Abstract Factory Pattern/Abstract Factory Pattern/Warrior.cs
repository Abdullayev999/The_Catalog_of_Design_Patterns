using System;

namespace Abstract_Factory_Warcraft
{
    public abstract class Warrior : Unit
    {
        public override void Attack(Unit target)
        {
            target.HP -= Damage;
            Console.WriteLine("Melee attack");
        }
    }
}