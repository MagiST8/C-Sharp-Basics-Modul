using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTour = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            string stage = "";
            int points= 0; ;
            double average = 0;
            double percent = 0;
            int numberOfWonTour = 0;
            points = startingPoints;
            for (int i = 0; i <=numberOfTour; i++)
            {
                stage = Console.ReadLine();
                if (stage=="F")
                {
                     points +=1200; ;
                }
                else if (stage=="SF")
                {
                    points += 720;
                }
                else if (stage=="W")
                {
                     points += 2000;
                    numberOfWonTour++;
                }
            }
            average = (points - startingPoints) / numberOfTour;
            percent = ((double)numberOfWonTour / numberOfTour) * 100;
            
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
