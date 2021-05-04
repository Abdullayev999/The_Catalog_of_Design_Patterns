using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IEnemyState
    {
        Enemy Enemy { get; set; }
        void Action();
    }

    class IdleState : IEnemyState
    {
        public Enemy Enemy { get; set; }

        public void Action()
        {
            Console.WriteLine("Idle...");
        }
    }

    class PlayerNearbyState : IEnemyState
    {
        public Enemy Enemy { get; set; }

        public void Action()
        {
            if (Enemy.HP > 10)
            {
                Console.WriteLine("Attack player!");
            }
            else
            {
                Enemy.CurrentState = new LowHPState() { Enemy = Enemy };
            }
        }
    }

    class LowHPState : IEnemyState
    {
        public Enemy Enemy { get; set; }

        public void Action()
        {
            Console.WriteLine("Run away!");
        }
    }

    class Enemy
    {
        public IEnemyState CurrentState { get; set; }

        public int HP { get; set; }

        public Enemy()
        {
            CurrentState = new IdleState() { Enemy = this };
        }

        public void Action()
        {
            CurrentState.Action();
        }
    }
}
