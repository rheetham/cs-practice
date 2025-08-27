namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                2,3,4,1,5,7,6,9,8
            };

            System.Array.Sort(numbers);

            foreach(int number in numbers)
            {
                System.Console.Write($"{number} ");
            }
        }
    }
}