using System;
using System.Diagnostics;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAge = 43;
            Console.WriteLine(currentAge);

            int whatIsAThousandYears = 1000;
            Console.WriteLine(whatIsAThousandYears);

            string firstName = "Steve,";
            Console.WriteLine(firstName);

            string saySomething = "Stop looking at me!!!";
            Console.WriteLine(saySomething);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            float val1 = 1.001f;
            float val2 = 1.002F;
            Console.WriteLine(val1);
            Console.WriteLine(val2);

            double a = 1.0;
            decimal b = 2.1m;
            Console.WriteLine(a + (double)b);
            Console.WriteLine((decimal)a + b);

            // Concatenate two string variables    
            string name = firstName + " " + saySomething;
            Console.WriteLine(name);

            // Create s int variable with the year as a string 
            int BirthYear = Int32.Parse("1977");
            Console.WriteLine("I was born in {0}.", BirthYear);
            

            Console.ReadLine();
        }
    }
}
