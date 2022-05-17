using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double metersGreening = double.Parse(Console.ReadLine());

            double priceMeters = 7.61;
            double precent = 18;

            double priceGreening = metersGreening * priceMeters;
            double discount = (precent / 100) * priceGreening;
            double totalPrice = priceGreening - discount;
            Console.WriteLine("The dinal prise is " + totalPrice + " lv");
            Console.WriteLine("The discount is " + discount + " lv");

        }
    }
}
