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

            Console.Write("Enter the position to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());
            int index = position - 1;

            for (int i = index; i < arr.Length - 1; ++i)
            {
                arr[i] = arr[i + 1];
            }

            for (int i = 0; i < arr.Length - 1; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}