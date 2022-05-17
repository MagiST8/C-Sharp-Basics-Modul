using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int sum = ((hour * 60) + min + 15);
            int resulthour = sum / 60;
            if (resulthour >= 24)
            {
                resulthour -= 24;
            }
            int resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
        }
    }
}
