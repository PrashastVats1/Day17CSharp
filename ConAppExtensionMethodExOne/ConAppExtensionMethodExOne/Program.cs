using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppExtensionMethodExOne
{
    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string inputSentence = Console.ReadLine();
            string capitalizedSentence = inputSentence.CapitalizeFirstLetter();
            Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");
            Console.ReadKey();
        }
    }
}
