using Restaraunt;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestarauntEncapsulation
{
    public class Waiter
    {
        private Kitchen kitchen;
        public Waiter(string name, Kitchen kitchen)
        {
            Name = name;
            this.kitchen = kitchen;
        }
        
        public void OrderReady(string order)
        {
            Console.WriteLine($"{Name}: Yay now I can serve my customer with {order}");
        }

        public void ApologiseToClient(string message)
        {
            Console.WriteLine($"{Name}: Kitchen messed up, really sorry!");
        }

        public void MakeOrder(string order, string specials = null)
        {
            Console.WriteLine($"{Name}: Making an order {order}");
            kitchen.TakeOrder(this, order, specials);
            
        }

        public string Name { get; set; }
    }
}
