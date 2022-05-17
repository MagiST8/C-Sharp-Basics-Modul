﻿using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                string assesorName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                academyPoints += (assesorName.Length * points) / 2;
                if (academyPoints>=1250.5)
                {
                    break;
                }

            }
            if (academyPoints>=1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5-academyPoints:f1} more!");
            }
        }
    }
}
