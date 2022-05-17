using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //ot konzolata poluchavame radiani
            //preobrazuvane v gradusi =>degrees=radians*180*Match.PI
            //otpechatwane na gradusi
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(degrees);

        }
    }
}
