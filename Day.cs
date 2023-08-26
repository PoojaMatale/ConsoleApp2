using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Day
    {
        static void Main(string[] args)
            {
            Console.WriteLine("enter no");
            int no= Convert.ToInt32(Console.ReadLine());
            if (no == 0)
            {
                Console.WriteLine("sunday");
            }
            else if (no == 1)
            {
                Console.WriteLine("monday");
            }
            else if (no == 2)
            {
                Console.WriteLine("tuesday");
            }
            else if (no == 3)
            {
                Console.WriteLine("wednesday");
            }
            else if (no == 4)
            {
                Console.WriteLine("thursday");
            }
            else if (no == 5)
            {
                Console.WriteLine("friday");
            }
            else if (no == 6)
            {
                Console.WriteLine("saturaday");
            }
            else
            {
                Console.WriteLine( "Wrong");
            }





        }
    }
}
