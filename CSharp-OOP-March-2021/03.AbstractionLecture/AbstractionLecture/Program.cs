using AbstractionLecture.Contracts;
using System;

namespace AbstractionLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kitchen kitchen = new Kitchen();
            GourmetKitchen kitchen = new GourmetKitchen();
            //Waiter
            Waiter waiter = new Waiter() { Kitchen = kitchen };
            waiter.Kitchen = kitchen;
            Console.WriteLine("Order a meal:");
            var mealName = Console.ReadLine();
            waiter.Kitchen.OrderMeal(mealName);

            // Techinician
            Techinician tech = new Techinician() { Kitchen = kitchen };
            tech.Kitchen.ListAllMachineries();
            
            // CEO
            CEO ceo = new CEO() { Kitchen = kitchen };
            ceo.Kitchen.CalculateCost();
        }
    }
}
