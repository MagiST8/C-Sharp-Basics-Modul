using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sell = double.Parse(Console.ReadLine());
           
            double price = 0;
            if ( 0<=sell && sell <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        price = 5;
                        break;
                    case "Varna":
                        price = 4.5;
                        break;
                    case "Plovdiv":
                        price = 5.5;
                        break;

                }
            }
            else if ( 500<sell && sell <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        price = 7;
                        break;
                    case "Varna":
                        price = 7.5;
                        break;
                    case "Plovdiv":
                        price = 8;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }
            else if (1000<sell && sell <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        price = 8;
                        break;
                    case "Varna":
                        price = 10;
                        break;
                    case "Plovdiv":
                        price = 12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sell > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                       price = 12  ;
                        break;
                    case "Varna":
                       price = 13;
                        break;
                    case "Plovdiv":
                        price = 14.5 ;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            double total = (sell * price)/100;
            if (total!=0)
            {
                Console.WriteLine($"{total:f2}");
            }
           
            

           
        }
    }
}
