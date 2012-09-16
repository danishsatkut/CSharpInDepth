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

            Predicate<Product> test = delegate(Product p) { return p.Price > 25m; };
            List<Product> matches = products.FindAll(test);

            Action<Product> print = delegate(Product p) { Console.WriteLine(p); };
            ((List<Product>) matches.OrderBy(p => p.Name)).ForEach(print);

            #endregion
        }
    }
}
