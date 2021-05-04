using System;
using System.Collections.Generic;

namespace Object_Pool_Pattern
{

    interface IObjectPool<T>
    {
        T Get();
        void Return(T obj);
    }

    class Program
    {
        static void DrawEnemy(Enemy enemy)
        {
            Console.SetCursorPosition(enemy.X, enemy.Y);
            Console.Write(enemy.Name);
        }

        static void Main(string[] args)
        {

            var enemyPool = new EnemyPool();
            var enemyList = new List<Enemy>();
            var random = new Random();

            while (true)
            {
                foreach (var enemy in enemyList)
                {
                    enemyPool.Return(enemy);
                }
                Console.Clear();

                for (int i = 0; i < random.Next(3, 10); i++)
                {
                    enemyList.Add(enemyPool.Get());
                    DrawEnemy(enemyList[i]);
                    System.Threading.Thread.Sleep(500);
                }

                Console.ReadKey();
            }
        }
    }
}
