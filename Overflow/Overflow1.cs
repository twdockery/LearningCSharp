low﻿using System;

namespace OverflowTesting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            byte number = 255;
            number = number +1 // 0 because of overflow
            Console.WriteLine("255 + 1 =" number);
        }
    }
}
