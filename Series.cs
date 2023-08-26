using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Series
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 2;
            Console.WriteLine("enter the number of element");
            int num = Convert.ToInt32(Console.ReadLine());
            while(i<=num)
            {
                f3 = f1 + f3;
                Console.WriteLine(f3);
                f1 = f2;
                f1 = f3;


            }

        }
    }
}
