using System;
using System.Collections.Generic;

namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            for (int i = 0; i < dict.Count; ++i)
            {
                KeyValuePair<int, string> pair = dict.ElementAt(i);
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            bool found = dict.TryGetValue(1, out string value);

            if (found)
            {
                Console.WriteLine($"{value}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}