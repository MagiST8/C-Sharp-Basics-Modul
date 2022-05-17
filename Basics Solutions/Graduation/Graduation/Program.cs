using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            double total = 0;
            int fail = 0;
            while (year <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());
                if (yearlyGrade < 4.00)
                {
                    fail++;
                    if (fail == 2)
                    {
                        break;
                    }
                    continue;
                }
                total += yearlyGrade;
                year++;
            }
            double averageGrade = total / 12;
            if (year<=12)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");

            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
