using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double chemicals = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double preparation = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double priceForChemicals = chemicals * 5.80;
            double priceForMarkers = markers * 7.20;
            double priceForPreparation = preparation * 1.20;
            double total = priceForChemicals + priceForMarkers + priceForPreparation;
            double discount = 0.25;
            double discountSum = total - (total * discount);

            Console.WriteLine(discountSum);

        }
    }
}
