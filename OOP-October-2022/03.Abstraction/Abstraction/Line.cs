using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Line : BaseShape
    {
        private int size;
        public Line(IDrawer drawer, int size) : base(drawer)
        {
            this.size = size;
        }


        public override void Draw()
        {
            for (int i = 0; i < size; i++)
            {
                drawer.Write("-");
            }
        }
    }
}
