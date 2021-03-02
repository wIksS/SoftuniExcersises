using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }

        public override void PrintName()
        {
            Console.WriteLine("Rectangle name");
        }
    }
}
