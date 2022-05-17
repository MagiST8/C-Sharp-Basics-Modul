using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeSize = cakeLength * cakeWidth;

            int cakeTaken = 0;
            string command = Console.ReadLine();

            while (command.ToUpper() != "STOP")
            {
                int currentSize = int.Parse(command);
                cakeTaken += currentSize;
                if (cakeTaken >= cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {cakeTaken - cakeSize} pieces more.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (cakeSize > cakeTaken)
            {
                Console.WriteLine($"{cakeSize - cakeTaken} pieces are left.");

            }
        }
    }    }