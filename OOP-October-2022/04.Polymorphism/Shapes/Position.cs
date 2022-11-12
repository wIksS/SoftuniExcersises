using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithoutPolymorphism
{
    public struct Position
    {
        public Position(int top, int left)
        {
            Top = top;
            Left = left;
        }

        public int Top { get; set; }
        public int Left { get; set; }
    }
}
