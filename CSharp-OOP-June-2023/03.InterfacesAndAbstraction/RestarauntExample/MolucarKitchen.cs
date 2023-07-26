using RestarauntExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntExample
{
    internal class MolucarKitchen : IOrderTaker
    {
        public void TakeOrder(string order)
        {
            Console.WriteLine($"Preparing {order}");
            Console.WriteLine($"{order} dissappeared");
        }
    }
}
