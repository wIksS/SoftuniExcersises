using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public abstract class Car : IDriveable
    {
        public abstract void Accelerate();

        public abstract void Decelerate();

        public virtual void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}
