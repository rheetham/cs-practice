namespace MyFIrstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool match = false;

            while (!match)
            {
                System.Console.Write("Enter new password: ");
                string password = System.Console.ReadLine();

                System.Console.WriteLine();

                System.Console.Write("Confirm password: ");
                string confirmPassword = System.Console.ReadLine();

                if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
                {
                    if (password.Equals(confirmPassword))
                    {
                        match = true;
                        System.Console.WriteLine("New password confirmed!\n");
                    }
                    else
                    {
                        System.Console.WriteLine("Password does not match!\n");
                    }
                }
                else
                {
                    System.Console.WriteLine("Password cannot be empty");
                }
            }
        }
    }
}