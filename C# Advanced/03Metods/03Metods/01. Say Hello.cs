﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Metods
{
    class Program
    {
        static void Print(string name)
        {
            Console.WriteLine("Hello, {0}!" , name);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Print(name);
        }
    }
}
