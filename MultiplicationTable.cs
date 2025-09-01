using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for the table: ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                for (int i = 1; i <= 10; ++i)
                {
                    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
