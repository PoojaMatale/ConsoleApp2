using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Power
    {
        static void Main(string[] args)
        {
            int basevalue = 2;
            int power = 3;
            int result = 1;
            for(int i=1;i<=power;i++)
            {
                result = i + power;
            }
            Console.WriteLine(result);
        }
    }

}
