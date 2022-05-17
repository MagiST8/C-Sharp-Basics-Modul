using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsNumber = int.Parse(Console.ReadLine());


            double priceStayStudio = 0;
            double priceStayApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStayApartment = nightsNumber * 65;
                priceStayStudio = nightsNumber * 50;
                if (nightsNumber > 7 && nightsNumber <= 14)
                {
                    priceStayStudio = nightsNumber * (50 * 0.95);
                }
                else if (nightsNumber > 14)
                {
                    priceStayStudio = nightsNumber * (50 * 0.70);
                }
                if (nightsNumber > 14)
                {
                    priceStayApartment = nightsNumber * (65 * 0.90);
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStayApartment = nightsNumber * 68.70;
                priceStayStudio = nightsNumber * 75.20;

                if (nightsNumber > 14)
                {
                    priceStayStudio = nightsNumber * (75.20 * 0.80);
                    priceStayApartment = nightsNumber * (68.70 * 0.90);
                }
            }

            else if (month == "July" || month == "August")
            {
                priceStayStudio = nightsNumber * 76;
                priceStayApartment = nightsNumber * 77;
                if (nightsNumber > 14)
                {
                    priceStayApartment = nightsNumber * (77 * 0.90);
                }

            }

            Console.WriteLine($"Apartment: {priceStayApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStayStudio:f2} lv.");

        }

    }
}

