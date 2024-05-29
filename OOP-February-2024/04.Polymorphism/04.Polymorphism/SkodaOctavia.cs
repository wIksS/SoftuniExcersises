using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public class SkodaOctavia : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Slowly going fast");
        }

        public override void Decelerate()
        {
            Console.WriteLine("Quickly going slow");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Ocatia start immediately");
        }
    }
}
