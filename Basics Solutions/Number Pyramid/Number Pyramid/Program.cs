using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            bool inBigger = false ;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if (currentNum>n)
                    {
                        inBigger = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                if (inBigger)
                {
                    break;
                }
            Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
