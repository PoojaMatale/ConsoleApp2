using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int no = Convert.ToInt32(Console.ReadLine());
            int num = 4569;
            int sum = 0;
            int count = 0;
            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10;

            }
            int avg = sum / count;
            
              

           
        }
    }
}
