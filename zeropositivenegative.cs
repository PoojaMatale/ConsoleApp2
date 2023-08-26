using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class zeropositivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine("postive");
            }
            else if(n==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
