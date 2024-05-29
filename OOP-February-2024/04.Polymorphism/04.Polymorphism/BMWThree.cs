using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    internal class BMWThree : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Quikcly going fast");
        }

        public override void Decelerate()
        {
            Console.WriteLine("Slowly going slow");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("BMW start immediately only in summer");
        }
    }
}
