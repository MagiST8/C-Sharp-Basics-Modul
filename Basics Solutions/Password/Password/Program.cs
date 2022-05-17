using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string unput = Console.ReadLine();
            while (unput!=password)
            {
                unput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
