using System;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int sumPeople = int.Parse(Console.ReadLine());

            double price = 0;
            if (sumPeople >= 1 && sumPeople <= 4)
            {
                price = budget * 0.75;
            }
            else if (sumPeople >= 5 && sumPeople <= 9)
            {
                price = budget * 0.60;
            }
            else if (sumPeople >= 10 && sumPeople <= 24)
            {
                price = budget * 0.50;
            }
            else if (sumPeople >= 25 && sumPeople <= 49)
            {
                price = budget * 0.40;
            }
            else
            {
                price = budget * 0.25;
            }

            double moneyLeft = budget - price;
            double ticket = category == "VIP" ? 499.99 : 249.99;
            double moneyForTickets = ticket * sumPeople;
            double left = Math.Abs(moneyLeft - moneyForTickets);

            if (moneyForTickets <= moneyLeft)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", left);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", left);
            }
        }


    }

}

