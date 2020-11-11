using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_bronze
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 525;

            //1         //2       //3
            for (int i = 500; i <= number; i++) // i is the loop control variable (LCV)
            {
                //4
                Console.WriteLine(i);
            }
            //5
            Console.ReadLine();

        }
    }
}
