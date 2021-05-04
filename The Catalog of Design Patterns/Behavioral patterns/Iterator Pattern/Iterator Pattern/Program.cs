using System;

namespace Iterator_Pattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var coll = new MyIntCollection(11, 22, 33, 44, 55);
            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }

            //var coll = new MyIntCollection(11, 22, 33, 44, 55);
            //var enumerator = coll.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}
            //enumerator.Reset();
        }
    }
}
