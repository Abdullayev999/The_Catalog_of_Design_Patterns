using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.Threading;

namespace Proxy
{
    class StudentRepository : IRepository<string, Student>
    {
        public void Add(Student student)
        {
            var list = GetAll();
            list.Add(student);

            string jsondata = JsonSerializer.Serialize(list);
            File.WriteAllText("data.json", jsondata);
        }
        public List<Student> GetAll()
        {
            if(File.Exists("data.json"))
            {
                string jsondata = File.ReadAllText("data.json");
                return JsonSerializer.Deserialize<List<Student>>(jsondata);
            }
            else
            {
                return new List<Student>();
            }
        }
        public Student Get(string fullname)
        {
            Thread.Sleep(3000); // network loading...
            var list = GetAll();
            var student = list.Where(s => s.FullName.Equals(fullname)).FirstOrDefault();
            return student;
        }
    }
}
