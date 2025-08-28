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

            int count = 1;
            int left = 0;
            int right = 0;
            int max_count = 0;
            int majority_element = 0;

            while (right < arr.Length - 1)
            {
                ++right;
                if (arr[left] == arr[right])
                {
                    ++count;
                }
                else
                {
                    if (count > max_count)
                    {
                        max_count = count;
                        majority_element = arr[left];
                    }
                    left = right;
                    count = 1;
                }
            }

            Console.WriteLine($"Majority element : {majority_element}");
        }
    }
}