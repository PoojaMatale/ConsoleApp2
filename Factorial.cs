using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine( "enter no");
            int no = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=no;i++)
            {
                factorial=factorial*i;
            }
            Console.WriteLine( "factorial=" +factorial);
        }
    }
}
