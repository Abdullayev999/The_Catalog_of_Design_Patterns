using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter_Pattern
{
    [Serializable]
    public class Contact
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{FullName} - {Phone} - {Email}";
        }
    }
}
