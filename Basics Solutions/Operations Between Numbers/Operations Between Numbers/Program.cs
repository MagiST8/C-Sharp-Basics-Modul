using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char sim = char.Parse(Console.ReadLine());
            double result = 0;


            if (sim == '+' || sim == '*' || sim == '-')
            {
                string evenOrOdd = "odd";
                if (sim == '+')
                {
                    result = n1 + n2;
                }
                else if (sim == '-')
                {
                    result = n1 - n2;
                }
                else if (sim == '*')
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{n1} {sim} {n2} = {result} - {evenOrOdd}");
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (sim == '/')
            {

                result = 1.0 * n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }


        }
    }
}
