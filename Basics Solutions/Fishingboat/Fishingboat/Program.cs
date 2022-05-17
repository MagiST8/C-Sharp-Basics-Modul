using System;

namespace Fishingboat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            int fisher = int.Parse(Console.ReadLine());
            double price = 0;
            switch (seson)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            if (fisher <= 6)
            {
                price = price - price * 0.10;
            }
            else if (fisher <= 11)
            {
                price = price - price * 0.15;
            }
            else if (fisher > 12)
            {
                price = price - price * 0.25;
            }
            if (fisher % 2 == 0 && seson != "Autumn")
            {
                price = price - price * 0.05;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");

            }






        }
    }
}

