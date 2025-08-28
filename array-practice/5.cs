using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; ++i) 
            {
                Console.Write($"Enter {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 4; ++i)
            {
                if(arr[i + 1] - arr[i] != 1) {
                    for (int j = arr[i] + 1; j < arr[i + 1]; ++j)
                    {
                        Console.Write($"{j} ");
                    }
                }
            }
        }
    }
}