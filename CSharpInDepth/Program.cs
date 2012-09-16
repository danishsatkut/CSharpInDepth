using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProducts();

            #region Sorting Funtionality

            Console.WriteLine("Products sorted by name: ");
            foreach (Product product in products.OrderBy(p => p.Name))
                Console.WriteLine(product);

            Console.WriteLine("\nProducts sorted by price: ");
            foreach (Product product in products.OrderBy(p => p.Price))
                Console.WriteLine(product);

            #endregion

            #region Querying Funtionality

            Console.WriteLine("\nProducts with price greater than 25: ");

            foreach (Product product in products.Where(p => p.Price > 25m))
            {
                Console.WriteLine(product);
            }

            #endregion
        }
    }
}
