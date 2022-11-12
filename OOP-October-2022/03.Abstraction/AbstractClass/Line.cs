using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    internal class Line : BaseShape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
