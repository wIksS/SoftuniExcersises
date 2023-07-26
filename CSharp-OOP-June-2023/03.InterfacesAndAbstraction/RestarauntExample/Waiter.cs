using RestarauntExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntExample
{
    internal class Waiter : IOrderTaker
    {
        private IOrderTaker kitchen;

        public Waiter(IOrderTaker kitchen)
        {
            this.kitchen = kitchen;
        }
        public void TakeOrder(string order)
        {
            Console.WriteLine("Go to bar and check order price");
            Console.WriteLine("ALl other steps that a waiter does");
            kitchen.TakeOrder(order);   
        }
    }
}
