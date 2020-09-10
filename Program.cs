using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number (other than 0): \t");
            while (!Int32.TryParse(Console.ReadLine(), out num1) || num1 == 0)
            {
                Console.Write("Invalid number enter again: \t");
            }
            Console.WriteLine();
            Console.Write("Enter second number(other than 0):\t");
            while (!Int32.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.Write("Invalid number enter again: \t");
            }
            Console.WriteLine();
            Console.WriteLine("Sum is:" + (num1 + num2));
            Console.WriteLine("Product is:" + num1 * num2);
            Console.WriteLine("Difference is:" + (num1 - num2));
            Console.WriteLine("Division of {0} by {1} is: {2}", num1, num2, num1 / num2);
            Console.ReadKey();
        }
    }
}
