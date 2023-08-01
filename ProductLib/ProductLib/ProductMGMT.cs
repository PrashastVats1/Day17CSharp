using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class ProductMGMT
    {
        static List<Product> products;
        public ProductMGMT()
        {
            products = new List<Product>()
            {
                new Product { ID = 1, Name = "Herbal Shampoo", Price = 230.50, MfDate = new DateTime(day: 12, month: 11, year: 2022) },
                new Product { ID = 2, Name = "Dabur Honey", Price = 780.50, MfDate = new DateTime(day: 12, month: 10, year: 2021) },
                new Product { ID = 3, Name = "Matic Surf", Price = 2230.50, MfDate = new DateTime(day: 12, month: 12, year: 2022) },
                new Product { ID = 4, Name = "Tata Gold Tea", Price = 730.50, MfDate = new DateTime(day: 02, month: 02, year: 2023) },
                new Product { ID = 5, Name = "Chicken Biryani", Price = 200.25, MfDate = new DateTime(day: 12, month: 11, year: 2022) },
                new Product { ID = 6, Name = "Face Wash", Price = 1230.50, MfDate = new DateTime(day: 01, month: 11, year: 2023) }
            };
        }
        public void PrintList()
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: \t{product.ID}");
                Console.WriteLine($"Name: \t{product.Name}");
                Console.WriteLine($"Price: \t{product.Price}");
                Console.WriteLine($"MfDate: \t{product.MfDate}");
            }
        }
        public void AddProduct(Product pro)
        {
            products.Add(pro);
            Console.WriteLine("List after adding a new product");
            this.PrintList();
        }
    }
}
