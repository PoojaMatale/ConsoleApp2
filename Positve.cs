using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class Positve
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = number > 0 ? "positive number" : "negative number";
            Console.WriteLine(result);

        }
  }
}
