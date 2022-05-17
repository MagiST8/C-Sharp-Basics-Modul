using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceNylon = (nylon + 2) * 1.50;

            double pricePaint = (paint + paint * 0.1) * 14.50;
           double priceThinner = thinner * 5;
               

            double total = priceNylon + priceThinner + pricePaint + 0.40;
           double sumForWorker = (total * 0.3) * hours;
           double finish = total + sumForWorker;

            Console.WriteLine(finish);


        }
    }
}
