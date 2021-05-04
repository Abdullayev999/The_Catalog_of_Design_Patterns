using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepositoryProxy students = new StudentRepositoryProxy(new StudentRepository());
            Student student1 = students.Get("Ivan Ivanov");
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.ReadKey();

            Student student2 = students.Get("Amiran Todua");
            Console.WriteLine(student2);
            Console.WriteLine();
        }
    }
}
