using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMEter = double.Parse(Console.ReadLine());

            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;
            double reordIvan = distance * timePerMEter + delay;


            if (reordIvan < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {reordIvan:F2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was {reordIvan - worldRecord:F2} seconds slower.");
            }
        }
    }
}
