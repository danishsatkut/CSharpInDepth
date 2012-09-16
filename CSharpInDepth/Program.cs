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
            foreach (Product product in products)
                Console.WriteLine(product.ToString());
        }
    }
}
