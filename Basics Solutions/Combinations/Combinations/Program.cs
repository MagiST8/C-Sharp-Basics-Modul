using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//x1 + x2 + x3 = n
            int validCombinationsCount = 0;
            for (int i = 0; i <= n; i++)
            {
                
                for (int t = 0; t <= n; t++)
                {
                    
                    for (int l = 0; l <= n; l++)
                    {
                       
                        if (i + t + l == n)
                        {
                            validCombinationsCount++;
                           
                                                       
                        }

                    }
                }
            }
            Console.WriteLine(validCombinationsCount);
        }
    }
}
