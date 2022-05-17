using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int even;
            int odd;
            string current;
            for (int i = first; i <= second; i++)
            {
                current = i.ToString();
                even = 0;
                odd = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        even += current[j];
                    }
                    else
                    {
                        odd += current[j];
                    }
                }
                if (even==odd)
                {
                    Console.Write(current + " ");
                }
                
            }
            

        }
    }
}
