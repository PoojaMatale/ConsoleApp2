using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a charater");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("number");
            }
            else
            {
                Console.WriteLine("symbol");
            }
        }
    }
}
