using System;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new TxtDataReader();
            
            try
            {
                var total = dataReader.GetProductsTotalPrice("products.txt");
                Console.WriteLine(total);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
