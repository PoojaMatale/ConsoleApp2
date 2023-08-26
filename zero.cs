using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no == 0)
            {
                Console.WriteLine("zero");
            }
            else if (no >= 0)
            {
                Console.WriteLine("postive");
            }
            else (no >= 0)
            {
                Console.WriteLine("negative");
            }
          
                
        }
    }
}
