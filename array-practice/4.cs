using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            for (int i = 0; i < 5; ++i) 
            {
                Console.Write($"Enter {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the value to be inserted: ");
            
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the index to be inserted at: ");

            int index = Convert.ToInt32(Console.ReadLine());

            for (int i = arr.Length - 1; i >= index; --i)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = value;

            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}