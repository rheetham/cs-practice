using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIDE = 2;
            int[,] arr = new int[SIDE, SIDE];

            for (int i = 0; i < SIDE; ++i) 
            {
                for (int j = 0; j < SIDE; ++j)
                {
                    Console.Write($"Enter [{i}, {j}] element : ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int right_diagonal_sum = 0;
            int y = SIDE - 1;

            for (int x = 0; x < SIDE; ++x)
            {
                right_diagonal_sum += arr[x, y];
                --y;
            }

            Console.WriteLine($"Right diagonal sum is {right_diagonal_sum}");
        }
    }
}