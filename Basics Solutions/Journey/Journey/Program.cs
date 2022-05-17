using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double price = 0;
            string place = "";
            switch (season)
            {
                case "summer":
                    place = "Camp";
                    break;
                case "winter":
                    place = "Hotel";
                    break;
                default:
                    place = "Hotel";
                    break;
            }

            if (season == "summer" && budget <= 100)
            {
                price = budget * 0.30;
                destination = "Bulgaria";
            }
            else if (season == "winter" && budget <= 100)
            {
                price = budget * 0.70;
                destination = "Bulgaria";
            }
            else if (season == "summer" && budget <= 1000)
            {
                price = budget * 0.40;
                destination = "Balkans";
            }
            else if (season == "winter" && budget <= 1000)
            {
                price = budget * 0.80;
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                price = budget * 0.90;
                destination = "Europe";
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
	

	}
}

