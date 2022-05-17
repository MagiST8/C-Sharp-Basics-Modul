using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForExam = int.Parse(Console.ReadLine());
            int minForExam = int.Parse(Console.ReadLine());
            int timeForArrived = int.Parse(Console.ReadLine());
            int minForArrived = int.Parse(Console.ReadLine());
            int examTime = (timeForExam * 60) + minForExam;
            int arrivalTime = (timeForArrived * 60) + minForArrived;

            int TotalMinutes = arrivalTime - examTime;

            string studentArrival = "Late";
            if (TotalMinutes < -30)
            {
                studentArrival = "Early";
            }
            else if (TotalMinutes <= 0)
            {
                studentArrival = "On time";
            }
            else
            {
                studentArrival = "Late";
            }

            string result = "";
            if (TotalMinutes != 0 || TotalMinutes == 0)
            {
                int hoursDifference =
                    Math.Abs(TotalMinutes / 60);
                int minutesDifference =
                    Math.Abs(TotalMinutes % 60);

                if (hoursDifference > 0)
                {
                    result = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);

                }
                else
                {
                    result = minutesDifference + " minutes";
                }
                if (TotalMinutes < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }
                Console.WriteLine(studentArrival);
                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                }


            }
        }

    }
}    
