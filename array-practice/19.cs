using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int INT_MAX = 2147483647;
            int[] arr = new int[5];

            for (int i = 0; i < 5; ++i) 
            {
                Console.Write($"Enter {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            int sum = INT_MAX;
            int[] result = new int[2];

            for (int i = 0; i < 4; ++i)
            {
                int current_sum = arr[i] + arr[i + 1];
                if(current_sum < 0)
                {
                    current_sum = -current_sum;
                }

                if (current_sum < sum)
                {
                    sum = current_sum;
                    result[0] = arr[i];
                    result[1] = arr[i + 1];
                }
            }

            Console.WriteLine($"{result[0]}, {result[1]}");
        }
    }
}