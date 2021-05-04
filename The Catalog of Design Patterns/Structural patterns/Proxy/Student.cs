using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Student
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"Fullname: {FullName}, Birthday: {Birthday.ToShortDateString()}, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}
