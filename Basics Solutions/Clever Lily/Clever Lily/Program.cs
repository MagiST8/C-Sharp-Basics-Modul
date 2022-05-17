using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double sumMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    money = money + (i * 5 - 1);
                }
                else
                {
                    money = money + priceToy;
                }
            }
            if (money>=sumMachine)
            {
                Console.WriteLine($"Yes! {money-sumMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {sumMachine-money:f2}");
            }

        }
    }
}
