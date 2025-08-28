using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int INT_MIN = -2147483648;
            int[] arr = new int[8];

            for (int i = 0; i < 8; ++i) 
            {
                Console.Write($"Enter {i+1} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int largest = INT_MIN;
            int second_largest = INT_MIN;

            foreach (int number in arr)
            {
                if (number > largest)
                {
                    second_largest = largest;
                    largest = number;
                }

                if (number > second_largest && number < largest)
                {
                    second_largest = number;
                }
            }

            Console.WriteLine($"Second largest element: {second_largest}");
        }
    }
}