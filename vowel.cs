using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class vowel
    {
    static void Main(string[]args)
    { 
            Console.WriteLine( "enter yur charater");
            char c= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("charater is"+c);
            if(c=='a'|| c=='e' || c=='i' || c=='o' || c=='u')
            {
                Console.WriteLine("charater is vowel"+c);
            }
            else
            {
                Console.WriteLine("charater is constant"+c);
            }        

            




        }
    }
}
