using P02._DrawingShape_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02._DrawingShape_Before.Drawers
{
    class CircleDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("Drawing circle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
