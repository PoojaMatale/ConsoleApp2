using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   internal class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"adddition is{c}");

            int d = a - b;
            Console.WriteLine($"suubtration is{d}");

            int e = a * b;
            Console.WriteLine($"multiplication is {e}");
            double f = (double)a / b;
            Console.WriteLine($"division is {f}");

            int g = a % b;
            Console.WriteLine($"reamainder is/mod is{g}");


        }
        }
}
