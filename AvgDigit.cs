using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AvgDigit
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("enter the number");
            //int num=Convert.ToInt32(Console.ReadLine());
            int num=235;
            int rem = 0;
            int count = 0;
            int sum = 0;
            while (num > 0)
            { 
                rem = num % 10;
                if (rem % 2 != 0)
                {
                    Console.WriteLine(rem);
                   
                    sum = sum + rem;
                    num = num / 10;
                }
            }
            Console.WriteLine( sum);






        }
    }
}
