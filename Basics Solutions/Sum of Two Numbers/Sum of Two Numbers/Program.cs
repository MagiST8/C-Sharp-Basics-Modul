using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end= int.Parse(Console.ReadLine());
            int magic= int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start ; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    int sum = i + j;
                    if (sum==magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magic}");
        }
    }
}
