using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;

            //1         //2       //3
            for (int i = 1; i <= number; i++) // i is the loop control variable (LCV)
            {
                //4
                Console.WriteLine(i);
            }
            //5
            Console.ReadLine();
        }
    }
}