using RestarauntExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntExample
{
    internal class Kitchen : IOrderTaker
    {
        public void TakeOrder(string order)
        {
            Console.WriteLine($"Preparing {order}");
        }
    }
}
