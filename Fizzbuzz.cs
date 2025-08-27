using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            if(int.TryParse(Console.ReadLine(), out int num))
            {
                if(num % 3 == 0)
                {
                    Console.Write("fizz");
                }
                if(num % 5 == 0)
                {
                    Console.Write("buzz");
                }
            }
        }
    }
}