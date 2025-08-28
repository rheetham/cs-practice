using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];

            for (int i = 0; i < 8; ++i) 
            {
                Console.Write($"Enter {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the value to find the ceiling of: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int ceiling = 0;

            foreach (int number in arr)
            {
                if (number >= value)
                {
                    ceiling = number;
                    break;
                }
            }

            Console.WriteLine($"Ceiling of {value} is {ceiling}");
        }
    }
}