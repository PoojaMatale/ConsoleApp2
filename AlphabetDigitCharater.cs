using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AlphabetDigitCharater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the charater");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'a' && ch <= 'z'|| ch>='A' && ch<='z')
            {
                Console.WriteLine("alphabet");
            }
            else if(ch>='0' || ch<='9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special charater");
            }
            
            
                    

                
        }
    }
}
