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
            List<Product> productsSortedByName = Product.GetSampleProducts();
            List<Product> productsSortedByPrice = Product.GetSampleProducts();

            productsSortedByName.Sort(delegate(Product x, Product y)
            { return x.Name.CompareTo(y.Name); }
            );

            productsSortedByPrice.Sort((x, y) =>
            {
                return x.Price.CompareTo(y.Price);
            });

            Console.WriteLine("Products sorted by name: ");
            foreach (Product product in productsSortedByName)
                Console.WriteLine(product);

            Console.WriteLine("\nProducts sorted by price: ");
            foreach (Product product in productsSortedByPrice)
                Console.WriteLine(product);
        }
    }
}
