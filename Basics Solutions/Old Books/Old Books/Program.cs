using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int counter = 0;
            string input = Console.ReadLine();

            while (input!="No More Books")
            {
                if (input==book)
                {
                    break;
                }
                counter++;
                input = Console.ReadLine();
            }
            if (input==book)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
