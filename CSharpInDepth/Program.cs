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

            Console.WriteLine("Products sorted by name: ");
            foreach (Product product in products.OrderBy(p => p.Name))
                Console.WriteLine(product);

            Console.WriteLine("\nProducts sorted by price: ");
            foreach (Product product in products.OrderBy(p => p.Price))
                Console.WriteLine(product);
        }
    }
}
