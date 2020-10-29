using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Child : Person
    {
        public int Age { get; set; }
        public sealed override void Sleep()
        {
            Console.WriteLine("Dreaming for fayries");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
            base.Sleep();
        }
    }
}
