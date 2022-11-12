using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer
{
    internal class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }


        public override void Draw()
        {
            double radius=15;
            double thickness = 0.4;
            char symbol = '*';

            renderer.WriteLine("");
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        renderer.Write(symbol);
                    }
                    else
                    {
                        renderer.Write(" ");
                    }
                }
                renderer.WriteLine("");
            }
        }
    }
}
