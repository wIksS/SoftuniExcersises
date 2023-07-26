using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample.Cars.Contracts
{
    public abstract class Car : IDrivable
    {
        public abstract void Start();

        public abstract void Accelerate();

        public abstract void Break();

        public int Speed { get; set; }

        public override string ToString()
        {
            return $"Car speed is: {Speed}";
        }
    }
}
