using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;
            if (figureType=="square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figureType=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figureType=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
            }
            else if (figureType=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
            }
            Console.WriteLine($" {area:f3} ");

        }
        
    }
}
