using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    public class Driver
    {

        private IDrivable drivable;

        public Driver(IDrivable car)
        {
            this.drivable = car;
        }

        public void Start()
        {
            Console.WriteLine($"Start button clicked!");
            drivable.Start();
        }

        public void Accelerate()
        {
            Console.WriteLine($"Gas pedal pushed!");
            drivable.Accelerate();
        }


        public void Break()
        {
            Console.WriteLine($"Break pedal pushed!");
            drivable.Break();
        }
    }
}
