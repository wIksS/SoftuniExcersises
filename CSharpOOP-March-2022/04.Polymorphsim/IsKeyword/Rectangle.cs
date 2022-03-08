using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeyword
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
