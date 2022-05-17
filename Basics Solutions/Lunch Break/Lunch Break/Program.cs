using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int serierTime = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double lunch = lunchBreak / 8.0;
            
            double chill = lunchBreak / 4.0;
            double timeLeft = lunchBreak - (lunch + chill);
            double difference = timeLeft - serierTime;

            if (difference >= 0)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
