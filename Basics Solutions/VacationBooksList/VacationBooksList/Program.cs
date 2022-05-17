using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerOfPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int numerOfDays = int.Parse(Console.ReadLine());
            int sumForRead = numerOfPages / pages;
            int hoursForDay = sumForRead / numerOfDays;
            
            Console.WriteLine(hoursForDay);
        }
    }
}
