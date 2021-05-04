using System;
using System.Collections.Generic;

namespace Object_Pool_Pattern
{
    class EnemyPool : IObjectPool<Enemy>
    {
        private Queue<Enemy> enemies;
        private Random random;
        private readonly int maxEnemies = 10;

        public EnemyPool()
        {
            enemies = new Queue<Enemy>();
            random = new Random();

            for (int i = 0; i < maxEnemies; i++)
            {
                enemies.Enqueue(new Enemy());
            }
        }

        public Enemy Get()
        {
            if (enemies.Count > 0)
            {
                Enemy enemy = enemies.Dequeue();
                enemy.X = random.Next(0, 80);
                enemy.Y = random.Next(0, 20);
                return enemy;
            }
            else
            {
                return null;
            }
        }

        public void Return(Enemy enemy)
        {
            enemies.Enqueue(enemy);
        }
    }
}
