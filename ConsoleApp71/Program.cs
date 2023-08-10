using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            double num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter oprator:");
            string op = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("invalid.operator");
            }
            Console.ReadLine();
                    
        }
    }
}
