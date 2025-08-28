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

            Array.Sort(arr);

            int left = 0;
            int right = 0;
            int count = 0;
            while (right < arr.Length)
            {
                if(arr[left] == arr[right])
                {
                    ++count;
                }
                else
                {
                    Console.WriteLine($"{arr[left]} : {count}");
                    left = right;
                    count = 1;
                }
                ++right;
            }
            Console.WriteLine($"{arr[left]} : {count}");
        }
    }
}