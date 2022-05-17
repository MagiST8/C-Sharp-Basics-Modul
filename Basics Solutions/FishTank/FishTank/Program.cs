using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());

            double volumeFishTank = length * width * height;
            double volumeLitter = volumeFishTank * 0.001;
            double fullPlace = precent / 100;

            double needenLitters = volumeLitter * (1 - fullPlace);
            Console.WriteLine(needenLitters);



        }
    }
}
