using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   internal class Average
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a first no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "enter a second no");
            int b = Convert.ToInt32(Console.ReadLine());
            float avg=a+b / 2;
            Console.WriteLine(avg);

        }
    }
}
