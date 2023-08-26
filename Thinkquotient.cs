using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Thinkquotient
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" think quotient" + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("quotient"+i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("think");
                }
                else
                {
                    Console.WriteLine(i);
                }




            }
        }
    }

}
