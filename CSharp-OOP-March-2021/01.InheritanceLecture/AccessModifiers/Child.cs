using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Child : Base
    {
        public Child()
        {
            this.protectedField = 5;
            
        }

        public double Weight { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void BaseMethod()
        {
            base.BaseMethod();
            Console.WriteLine("I am the child method");
        }
    }
}
