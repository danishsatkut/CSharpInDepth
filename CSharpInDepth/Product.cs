using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInDepth
{
    class Product
    {
        readonly string name;
        public string Name 
        {
            get { return name; }
        }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Creates some sample product and returns them.
        /// </summary>
        /// <returns>List of products</returns>
        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product(name: "Prale Hide and Seek", price: 20m),
                new Product(name: "Maggie Noodles", price: 30m),
                new Product(name: "Nescafe Coffee", price: 56m),
                new Product(name: "C# in Depth", price: 499.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
