using System;
using System.Collections.Generic;
using System.Text;

namespace RestarauntNoEncapsulation
{
    public class Waiter
    {
        private Kitchen kitchen;
        public Waiter(string name, Kitchen kitchen)
        {
            Name = name;
            this.kitchen = kitchen;
        }

        public string Name { get; set; }

        public void TakeOrder(string order)
        {
            switch (order)
            {
                case "Risotto":
                    kitchen.MakeRise("");
                    break;

                case "ChickenRise":
                    kitchen.MakeChickenRise("");
                    break;
                default:
                    kitchen.UnknownOrder();
                    ApologiseToClient("Waiter did not know that we don't this on the menu");
                    return;
            }

            kitchen.Cook();

            kitchen.Ingredients = new List<Ingredient>();
        

        }

        public void ApologiseToClient(string message)
        {
            Console.WriteLine($"{Name}: Kitchen messed up, really sorry!");
        }

    }
}
