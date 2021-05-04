using System.Collections.Generic;
using System.Linq;

namespace Template_Method_Pattern
{
    abstract class DataReader
    {
        abstract public IEnumerable<Product> ReadProductsFromFile(string filename);

        virtual public decimal GetProductsTotalPrice(string filename)
        {
            var products = ReadProductsFromFile(filename);
            return products.Sum(x => x.Price);
        }
    }
}
