using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=num)
            {
                int fact = num % i;
                if(fact==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            
          
            

            




        }
    }
}
