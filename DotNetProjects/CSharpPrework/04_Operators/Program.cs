using System;

namespace _04_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
         int num1 = 10;
         int num2 = 2;
         int result;
         result = num1 + num2;
         Console.WriteLine("Value is {0}",result);
         result = num1 - num2;
         Console.WriteLine("Value is {0}",result);
         result = num1 * num2;
         Console.WriteLine("Value is {0}", result);
         result = num1 / num2;
         Console.WriteLine("Value is {0}", result);

         Console.WriteLine(10 % 5);
                
         Console.ReadLine();
        }
    }
}
