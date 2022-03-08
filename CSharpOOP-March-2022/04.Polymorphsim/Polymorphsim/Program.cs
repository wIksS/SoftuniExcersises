using System;

namespace Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotKitchen robotKitchen = new RobotKitchen();

            IRobotCleaner robotCleaner = robotKitchen;
            Kitchen baseKitchen = robotKitchen;
            robotCleaner.RobotClean();
            baseKitchen.CleanKitchen();
            int fifty = 50;
            long x = fifty;
            Console.WriteLine("What kitchen do you want to use?");
            string kitchenType = Console.ReadLine();

            Kitchen kitchen = new RobotKitchen();

            if (kitchenType == "old")
            {
                kitchen = new OldKitchen();
            }
            else if (kitchenType == "normal")
            {
                kitchen = new NormalKitchen();
            }
            else if (kitchenType == "modern")
            {
                kitchen = new ModernKitchen();
            }
            else if (kitchenType == "robot")
            {
                kitchen = new RobotKitchen();
            }

            while (true)
            {
                Console.WriteLine("What is your order?");

                var order = Console.ReadLine();

                if (order == "meat")
                {
                    kitchen.CookMeat();
                }
                if (order == "salad")
                {
                    kitchen.CookSalad();
                }
                if (order == "veggie")
                {
                    kitchen.CookVegetarian();
                }
                if (order == "clean")
                {
                    kitchen.CleanKitchen();
                }
                if (order == "robot clean")
                {
                    if (kitchen is RobotKitchen)
                    {
                        ((RobotKitchen)kitchen).RobotClean();
                    }
                    else
                    {
                        Console.WriteLine("Kuhnqta ti e stara :(");
                    }
                }
                if (order == "change kitchen")
                {
                    //TODO: change at any time
                }
            }
        }
    }
}
