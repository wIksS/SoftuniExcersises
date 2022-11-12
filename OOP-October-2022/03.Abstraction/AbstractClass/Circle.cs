using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    internal class Circle : BaseShape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
