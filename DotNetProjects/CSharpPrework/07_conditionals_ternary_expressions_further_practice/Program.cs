using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_ternary_expressions_further_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            location loc = location.hyderabad;

            switch (loc)

            {

                case location.chennai:

                    Console.WriteLine("Location: Chennai");

                    break;

                case location.guntur:

                    Console.WriteLine("Location: Guntur");

                    break;

                case location.hyderabad:

                    Console.WriteLine("Location: Hyderabad");

                    break;

                default:

                    Console.WriteLine("Not Known");

                    break;

            }

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();

        }

        public enum location

        {

            hyderabad,

            chennai,

            guntur

        }
    }
}
