using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_Price_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = new List<decimal>();
            decimal input;

            Console.WriteLine("Enter item prices (enter -1 to finish):");

            while (true)
            {
                Console.Write("Price: $");
                if (!decimal.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (input == -1)
                {
                    break; 
                }

                if (input < 0)
                {
                    Console.WriteLine("Prices cannot be negative. Please try again.");
                    continue;
                }

                prices.Add(input);
            }
            if (prices.Count > 0)
            {
                Console.WriteLine("\nPrice Analysis Results:");
                Console.WriteLine($"Total items: {prices.Count}");
                Console.WriteLine($"Average price: {prices.Average():C}");
                Console.WriteLine($"Highest price: {prices.Max():C}");
                Console.WriteLine($"Lowest price: {prices.Min():C}");
            }
            else
            {
                Console.WriteLine("\nNo prices were entered.");
            }
        }
    }
}
