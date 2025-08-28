using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIDE = 3;
            int[,] arr = new int[SIDE, SIDE];

            for (int i = 0; i < SIDE; ++i) 
            {
                for (int j = 0; j < SIDE; ++j)
                {
                    Console.Write($"Enter [{i}, {j}] element : ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 1; i < SIDE; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    arr[i, j] = 0;
                }
            }

            for (int i = 0; i < SIDE; ++i)
            {
                for (int j = 0; j < SIDE; ++j)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}