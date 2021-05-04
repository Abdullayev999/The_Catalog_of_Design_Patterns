using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Proxy
{
    class StudentRepositoryProxy : IRepository<string, Student>
    {
        private StudentRepository service;
        private List<Student> grobalStudent;
        public StudentRepositoryProxy(StudentRepository service)
        {
            this.service = service;
            grobalStudent = new List<Student>();
            grobalStudent.Add(new Student
            {
                FullName = "Amiran Todua",
                Birthday = new DateTime(1997, 09, 08),
                Email = "todua.amiran97@mail.ru",
                PhoneNumber = "+123321"
            });
        }
        public void Add(Student item)
        {
            service.Add(item);
        }
        public Student Get(string key)
        {
            var result = grobalStudent.Where(s => s.FullName.Equals(key)).FirstOrDefault();
            if (result != null) return result;
            else return service.Get(key);
        }
        public List<Student> GetAll()
        {
            return service.GetAll();
        }
    }
}
