using System;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (!string.IsNullOrEmpty(str))
            {
                for (int i = str.Length - 1; i >= 0; --i)
                {
                    Console.Write(str[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid String");
            }
        }
    }
}