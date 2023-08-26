using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   internal class Menudriven
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the first number");
            Convert.Todouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            Convert.Todouble(Console.ReadLine());
            Console.WriteLine("select for addition");
            Console.WriteLine("select for subtration");
            Console.WriteLine( "select for multiplicstion");
            Console.WriteLine("select for division");
            int option = Convert.ToInt32(Console.ReadLine());
            int result = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    result = a + b;
                    Console.WriteLine( "addition is result"+result);
                    break;
                case 2:

                    result = a - b;
                    Console.WriteLine("subtration is result"+result );
                    break;
                case 3:

                    result=a*b
                    Console.WriteLine( "multiplaication is result"+result);
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine( "division is result"+result);
                    break;
                    default;
                    Console.WriteLine("wrong");
                    break;


            }
           

        }
    }
}
