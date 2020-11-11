using System;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 101 % 2;
            if (value == 50)
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
            
            Console.ReadLine();
        }
    }
}
