﻿using System;

namespace Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 7; i <=997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
