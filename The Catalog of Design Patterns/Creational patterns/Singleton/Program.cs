using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            var singleton3 = Singleton.Instance;

            singleton1.Data.Add(1);
            singleton2.Data.Add(2);
            singleton3.Data.Add(3);

            foreach (var item in Singleton.Instance.Data)
            {
                Console.Write(item + " ");
            }
        }
    }
}
