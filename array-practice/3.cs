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

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5 - i - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}