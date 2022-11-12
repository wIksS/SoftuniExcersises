using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer
{
    internal class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.WriteLine("Drawing square");
        }
    }
}
