using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            int evaliation = 0;
            double sum = 0;
            int count = 0;
            string lastExercise = "";
            int failedCount = 0;
            string input = Console.ReadLine();
            while (input!="Enough")
            {
                lastExercise = input;
                evaliation = int.Parse(Console.ReadLine());
                sum += evaliation;
                count++;
                if (evaliation<=4)
                {
                    failedCount++;
                    if (failedTimes==failedCount)
                    {
                        break;
                    }
                     
                }
                input = Console.ReadLine();
            }
            if (input=="Enough")
            {
                Console.WriteLine($"Average score: {sum/count:f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failedCount} poor grades.");
            }

        }
    }
}
