using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double bugetPeter = double.Parse(Console.ReadLine());
            int videoCarts = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());


            double sumVideoCarts = videoCarts * 250;

            double priceForProcesor = sumVideoCarts * 0.35;
            double sumForProcesor = procesor * priceForProcesor;

            double priceForRamMemory = sumVideoCarts * 0.10;
            double sumForRamMemory = ramMemory * priceForRamMemory;
             
            double totalSum = sumVideoCarts + sumForRamMemory + sumForProcesor;

            if (videoCarts >= procesor)
            {
                totalSum = totalSum - totalSum * 0.15;
            }
            if (bugetPeter >= totalSum)
            {
                Console.WriteLine($"You have {bugetPeter - totalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - bugetPeter:F2} leva more!");
            }


        }
    }
}
