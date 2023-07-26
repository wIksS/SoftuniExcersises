using CarExample.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    public class DieselCar : Car
    {
        public override void Start()
        {
            Console.WriteLine("Starting engine");
            Console.WriteLine("Doing complex stuff with  engine -> 200 lines of code");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Put more power in engine");
            Console.WriteLine($"Speed: {++Speed}");
        }

        public override void Break()
        {
            Console.WriteLine("Put more power in breaks");
            Console.WriteLine($"Speed: {--Speed}");
        }
    }
}
