using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_switch_case_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            switch (inputName)
            {
                case "greg": // Same as checking: if (inputName == "greg")
                    Console.WriteLine("Hey bro, how's work?");
                    break;

                case "dad": // Same as checking: else if (inputName == "dad")
                    Console.WriteLine("Let's hang.");
                    break;

                case "terrance": // Same as checking: else if (inputName == "terrance")
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;

                default: // Same as: else
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break;
            }

            {
                Console.ReadLine();
            }
        }
    }
}
