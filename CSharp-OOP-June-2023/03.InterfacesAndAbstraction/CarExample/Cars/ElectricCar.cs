using CarExample.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    internal class ElectricCar : Car
    {
        public override void Start()
        {
            Console.WriteLine("Starting engine");
        }

        public override void Accelerate()
        {
            ++Speed;
            Console.WriteLine("Put more power in engine");
            Console.WriteLine($"Speed: {++Speed}");
            
        }

        public override void Break()
        {
            --Speed;
            Console.WriteLine("Put more power in breaks");
            Console.WriteLine($"Speed: {--Speed}");
        }

    }
}
