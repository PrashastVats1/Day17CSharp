using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CalcLib;

namespace ConAppUsageOfLib
{
    public static class MyClass
    {
        public static void Welcome(this Calc obj)
        {
            Console.WriteLine("Welcome to calculator");
        }
        public static double Avg(this Calc ob, double num1, double num2) 
        {
            double result = ((ob.Add(num1, num2)) / 2);
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter first number");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ennter second number");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose operation");
                Console.WriteLine("1. Addition\n2. Subtraction\n3. Dividsion\n4. Multiplication\n5. Average");
                int op = int.Parse(Console.ReadLine());
                Calc cal = new Calc();
                cal.Welcome();
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Reasult after addition is: \t" + cal.Add(num1, num2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Reasult after subtraction is: \t" + cal.Sub(num1, num2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Reasult after division is: \t" + cal.Div(num1, num2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Reasult after multiplication is: \t" + cal.Multi(num1, num2));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Reasult after average is: \t" + cal.Avg(num1, num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation chioce");
                            break;
                        }
                }
                Console.WriteLine("If wanna continue, press y ");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");

            Console.ReadKey();
        }
    }
}
