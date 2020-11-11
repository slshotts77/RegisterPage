using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditional_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            switch (inputName)
            {
                case "fred": // Same as checking: if (inputName == "fred")
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    break;

                case "karl": // Same as checking: else if (inputName == "karl")
                    Console.WriteLine("Let's hang.");
                    break;

                case "john": // Same as checking: else if (inputName == "john")
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

