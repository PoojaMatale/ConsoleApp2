﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   internal class Odd_for
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=20;i++)
            {
               if(i%2!=0)
                {
                    Console.WriteLine( "odd no"+i);
                    count++;
                }
                Console.WriteLine(count);



            }
        }
   }
}
