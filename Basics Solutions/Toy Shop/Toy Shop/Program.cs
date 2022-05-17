using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            double price = double.Parse(Console.ReadLine());

            int numOfPuzzle = int.Parse(Console.ReadLine());
            int numOfDoll = int.Parse(Console.ReadLine());
            int numOfBear = int.Parse(Console.ReadLine());
            int numOfMinion = int.Parse(Console.ReadLine());
            int numOfTruck = int.Parse(Console.ReadLine());

            int toys = numOfBear + numOfDoll + numOfMinion + numOfPuzzle + numOfTruck;

            double puzzlePrice = numOfPuzzle * 2.60;
            double dollPrice = numOfDoll * 3;
            double bearPrice = numOfBear * 4.10;
            double minionPrice = numOfMinion * 8.20;
            double truckPrice = numOfTruck * 2;

            double profit = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;

            if (toys >= 50)
            {
                profit = profit - profit * 0.25;
            }
            profit = profit - profit * 0.1;
            double difference = profit - price;
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");

            }
        }
    }
}
