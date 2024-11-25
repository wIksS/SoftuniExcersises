using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public class Waiter : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Going to all clients");
        }
    }
}
