using System;
using System.Collections.Generic;
using System.IO;

namespace Template_Method_Pattern
{
    class TxtDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProductsFromFile(string filename)
        {
            List<Product> products = new List<Product>();

            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var items = line.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                products.Add(new Product
                {
                    Title = items[0],
                    Price = decimal.Parse(items[1])
                });
            }

            return products;
        }
    }
}
