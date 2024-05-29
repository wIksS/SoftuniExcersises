using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    internal class JetSki : IDriveable
    {
        public void Accelerate()
        {
            Console.WriteLine("Going on water");
        }

        public void Decelerate()
        {
            Console.WriteLine("stoppping on water");
        }

        public void Start()
        {
            Console.WriteLine("starting on water");
        }

        public void Stop()
        {
            Console.WriteLine("turnig off on water");
        }

        public void SplashWater()
        {
            Console.WriteLine("Haha");
        }

        public int Hours { get; set; }
    }
}
