namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5
            };

            System.Console.Write("Enter number to search: ");

            if (!int.TryParse(System.Console.ReadLine(), out int search))
            {
                System.Console.WriteLine("Bad Input");
                return;
            }

            int index = System.Array.IndexOf(numbers, search);
            if (index >= 0)
            {
                System.Console.WriteLine($"{search} found at index {index}");
            }
            else
            {
                System.Console.WriteLine($"{search} not present in array");
            }
        }
    }
}