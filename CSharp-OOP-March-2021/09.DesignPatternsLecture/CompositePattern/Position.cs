using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
