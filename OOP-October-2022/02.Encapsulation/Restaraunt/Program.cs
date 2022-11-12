using RestarauntEncapsulation;
using System;
using System.Collections.Generic;

namespace Restaraunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Tomatoe", 5000),
                new Ingredient("Onion", 1000),
                new Ingredient("Chicken", 4000),
                new Ingredient("Olive Oil", 5000),
            };

            Kitchen kitchen = new Kitchen(ingredients);

            Waiter penkaWaiter = new Waiter("Penka", kitchen);
            Waiter dimitrichkoWaiter = new Waiter("Dimitrichko", kitchen);

            List<Waiter> waiters = new List<Waiter>() { penkaWaiter,dimitrichkoWaiter};
            Random random = new Random();

            
            kitchen.TakeOrder(penkaWaiter, "Risotto", "");

            while (true)
            {
                string order = Console.ReadLine();
                Waiter waiter = waiters[random.Next(0, waiters.Count)];
                waiter.MakeOrder(order);
            }
        }
    }
}
