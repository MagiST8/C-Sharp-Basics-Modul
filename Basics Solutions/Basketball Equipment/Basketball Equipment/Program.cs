using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double trainersPrice = taxPerYear - (taxPerYear * 0.4);
            double outfitPrice = trainersPrice - (trainersPrice * 0.2);
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;
            double expenses = taxPerYear + trainersPrice + outfitPrice + ballPrice + accPrice;
            Console.WriteLine(expenses);

        }
    }
}
