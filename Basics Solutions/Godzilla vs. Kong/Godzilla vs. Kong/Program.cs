using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            double buged = double.Parse(Console.ReadLine());
            int stilist = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            //2)
            double decor = buged * 0.10;
            double clothing = stilist * clothingPrice;

            if (stilist >= 150)
            {
                clothing = clothing - clothing * 0.10;
            }
            double neededMoney = clothing + decor;
            double difference = buged - neededMoney;

            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");

            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");
            }
        }
    }
}
