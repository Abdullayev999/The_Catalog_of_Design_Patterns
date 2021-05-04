using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Price}";
        }
    }
}
