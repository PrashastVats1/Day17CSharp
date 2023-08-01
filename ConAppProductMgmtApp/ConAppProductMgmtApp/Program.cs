using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ConAppProductMgmtApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("1.Show Lsit \n2.Add Product");
                int op = int.Parse(Console.ReadLine());
                ProductMGMT mgmt = new ProductMGMT();
                switch (op)
                {
                    case 1:
                        {
                            mgmt.PrintList();
                            break;
                        }
                    case 2:
                        {
                            Product obj = new Product();
                            Console.WriteLine("Enter Id");
                            obj.ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Product Name");
                            obj.Name = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            obj.Price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Manufacturing date");
                            obj.MfDate = DateTime.Parse(Console.ReadLine());
                            mgmt.AddProduct(obj);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Operation");
                            break;
                        }
                }
                Console.WriteLine("To continue press y");
                choice = Console.ReadLine().ToLower(); ;
            } while (choice == "y");   
        }
    }
}
