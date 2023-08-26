using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value od breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = l * b;
            Console.WriteLine(c);
        }
    }
}

