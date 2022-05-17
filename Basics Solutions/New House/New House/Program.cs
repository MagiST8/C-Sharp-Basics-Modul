using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());

            double price = 0;
            ;
            if (flowers == "Roses")
            {
                price = count * 5;
                if (count > 80)
                {
                    
                    price = price - price * 0.10;
                }

            }
            else if (flowers == "Dahlias")
            {
                price = count * 3.80;
                if (count > 90)
                {
                   
                    price = price - price * 0.15;


                }
            }
            else if (flowers == "Tulips")
            {
                price = count * 2.80;
                if (count > 80)
                {
                    price = price - price * 0.15;

                }
            }
            else if (flowers == "Narcissus")
            {
                price = count * 3;
                if (count < 120)
                {
                    
                    price = price + price * 0.15;
                    
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = count * 2.50;
                if (count < 80)
                {
                   
                    price = price + price * 0.20;

                }

            }
            if (buget<price)
            {
                Console.WriteLine($"Not enough money, you need {(price-buget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {(buget-price):f2} leva left.");

            }
        }
    }
}

