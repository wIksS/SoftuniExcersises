using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Circle : BaseShape
    {
        private int size;
        public Circle(IDrawer drawer, int size) : base(drawer)
        {
            this.size = size;
        }

        public override void Draw()
        {
            double radius = size;
            double thickness = 0.4;
            char symbol = '*';

            double rIn = radius - thickness, rOut = radius + thickness;
            drawer.WriteLine();
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        drawer.Write(symbol.ToString());
                    }
                    else
                    {
                        drawer.Write(" ");
                    }
                }

                drawer.WriteLine();
            }
        }
    }
}
