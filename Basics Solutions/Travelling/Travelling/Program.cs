using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
         
            while (destination!="End")
            {
                double money = double.Parse(Console.ReadLine());
                double saving = 0;
                while (saving<money)
                {
                    saving += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
