﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.BackgroundColor= ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("{0} {1}.", myString, myInteger);
            Console.ReadKey();
            Console.BackgroundColor= ConsoleColor.Magenta;
        }
    }
}