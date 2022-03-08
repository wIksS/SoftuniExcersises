using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeyword
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle Draw");
        }

        public int Radius { get; set; }
    }
}
