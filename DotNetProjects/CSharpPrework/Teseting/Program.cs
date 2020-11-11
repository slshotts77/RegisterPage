using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teseting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Steve";
            Console.WriteLine(firstName);
            
            string lastName = "Shotts";
            Console.WriteLine(lastName);

            string birthYear = "1977";
            Console.WriteLine(birthYear);

            Console.Write("How old are you?");
            int yourAge = Convert.ToInt16(Console.ReadLine());
               
            if (yourAge >= 17)
                {
                    Console.WriteLine("Adult Verification Aquired");
                }

                else
                { 
                    Console.WriteLine("Sorry, we recognize you as a minor!!!");
                }

                Console.ReadLine();
        }
    }
}