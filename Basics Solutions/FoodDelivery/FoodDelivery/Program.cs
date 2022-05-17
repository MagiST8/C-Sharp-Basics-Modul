using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chikenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegiMenu = double.Parse(Console.ReadLine());

            double menuChiken = chikenMenu * 10.35;
            double menuFish = fishMenu * 12.40;
            double menuVegi = vegiMenu * 8.15;
            double allMenus = menuChiken + menuFish + menuVegi;
            double dessert = allMenus * 0.2;
            double delivery = 2.50;
            double priceForDelivery = dessert + allMenus + 2.50;
            Console.WriteLine(priceForDelivery);
        }
    }
}
