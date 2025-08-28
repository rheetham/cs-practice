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

            Console.Write("Enter the number of positions to rotate: ");
            int positions = Convert.ToInt32(Console.ReadLine());

            int[] beginning = new int[positions];

            for (int i = 0; i < positions; ++i)
            {
                beginning[i] = arr[i];
            }

            int index = 0;
            for (int i = positions; i < arr.Length; ++i)
            {
                arr[index++] = arr[i];
            }

            index = 0;
            for (int i = positions; i < arr.Length; ++i)
            {
                arr[i] = beginning[index++];
            }

            foreach (int number in arr)
            {
                Console.Write($"{number} ");
            }
        }
    }
}