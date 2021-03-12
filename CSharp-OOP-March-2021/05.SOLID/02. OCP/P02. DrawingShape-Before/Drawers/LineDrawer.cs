using P02._DrawingShape_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02._DrawingShape_Before.Drawers
{
    class LineDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Line line = shape as Line;
            Console.WriteLine("Drawing line");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Line;
        }
    }
}
