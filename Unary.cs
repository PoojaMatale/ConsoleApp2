using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class Unary
  {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);
            x = a++ - b--;
            Console.WriteLine(x + " " + a + " " + b);
            x = ++a - b++;
            Console.WriteLine(x + " " + a + " " + b);
            x = --a - --b;
            Console.WriteLine(x + " " + a + " " + b);
            x = ++a + ++b - b;
            Console.WriteLine(x + " " + a + " " + b);


        }
   }
}
