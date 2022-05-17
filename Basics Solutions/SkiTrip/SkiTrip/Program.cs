using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
     
            {
                int stayDay = int.Parse(Console.ReadLine());
                string place = Console.ReadLine();
                string vote = Console.ReadLine();
                double price = 0;


                if (place == "room for one person")
                {
                    price = (stayDay - 1) * 18;

                }
                else if (place == "apartment")
                {
                    price = (stayDay - 1) * 25;
                    if (stayDay < 10)
                    {
                        price = price - price * 0.30;
                    }
                    else if (stayDay >= 10 && stayDay <= 15)
                    {
                        price = price - price * 0.35;
                    }
                    else
                    {
                        price = price - price * 0.50;
                    }
                }
                else if (place == "president apartment")
                {
                    price = (stayDay - 1) * 35;
                    if (stayDay < 10)
                    {
                        price = price - price * 0.10;
                    }
                    else if (stayDay >= 10 && stayDay <= 15)
                    {
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price = price - price * 0.20;
                    }
                }
                if (vote == "positive")
                {
                    price += price * 0.25;
                }
                else if (vote == "negative")
                {
                    price -= price * 0.10;
                }



                Console.WriteLine("{0:f2}", price);


            }
        }
    }

}
    