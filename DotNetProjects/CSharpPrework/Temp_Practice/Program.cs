using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 74;

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();

        }

    }
}
