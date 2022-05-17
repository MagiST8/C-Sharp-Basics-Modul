using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeofday = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeofday == "Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }

                else if (timeofday == "Afternoon")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }

                else if (timeofday == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
            }

            else if (degrees > 18 && degrees <= 24)
            {
                if (timeofday == "Morning")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
                else if (timeofday == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
                else if (timeofday == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
            }

            else if (degrees >= 25)
            {
                if (timeofday == "Morning")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
                else if (timeofday == "Afternoon")
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
                else if (timeofday == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
                }
            }
           
        }
    }
}
