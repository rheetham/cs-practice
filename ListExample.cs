using System;
using System.Collections.Generic;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            for (int i = 0; i < numbers.Count; ++i)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            numbers.Remove(3);
            numbers.RemoveAt(1);

            for (int i = 0; i < numbers.Count; ++i)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
