﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Bill = 54.23M; //MUST INCLUDE THE "M" TO INDICATE DECIMAL
            decimal Tip = 12;

            decimal Percentage = Tip / Bill;

            Console.WriteLine(Percentage);
            Console.WriteLine(Math.Round(Percentage, 2));

            Console.ReadLine();
        }
    }
}