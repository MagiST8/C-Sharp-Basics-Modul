using System;

namespace newvacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int count = 0;
            int spendCount = 0;
            
            while (availableMoney<neededMoney && spendCount<5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                count++;
                if (command=="save")
                {
                    availableMoney += money;
                    spendCount = 0;
                }
                if (availableMoney<0)
                {
                    availableMoney = 0;
                }
                if (command=="spend")
                {
                    availableMoney -= money;
                    spendCount++;
                }
              
            }
            if (spendCount==5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(count);
            }
           
            if (availableMoney>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
        }
    }
}
