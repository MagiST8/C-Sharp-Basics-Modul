using System;

namespace PetSHop
{
    class Program
    {
        static void Main(string[] args)
        {
            //double footForDog = 2.50;
            //int footForCat = 4;
            double dog = double.Parse(Console.ReadLine());

            double cat = double.Parse(Console.ReadLine());

            double costDog = dog * 2.50;
            double costCat = cat * 4;
            double cost = costCat + costDog;

            Console.WriteLine(cost + " lv.");
        }
    }
}
