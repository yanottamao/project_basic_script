using System;

namespace input_script
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);
        }
    }
}
