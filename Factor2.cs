using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factor2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fact = 1;
            int no = 5;
            for (int i=1;i<no;i++)
            {
                fact = fact * i;
                sum = sum + fact;

            }
            Console.WriteLine(sum);
        }
    }**/
}
