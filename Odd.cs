﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Odd
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=50;i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine( "odd no"+i);
                }
            
            }
        }
    }
}
