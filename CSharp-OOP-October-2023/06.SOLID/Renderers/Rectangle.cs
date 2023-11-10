using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    internal class Rectangle : Shape
    {
        public Rectangle(IRenderer renderer, Position position) : base(renderer, position)
        {
        }

        public override void Draw()
        {
            renderer.WriteLine("****", Position);
            renderer.WriteLine("****", Position);
            renderer.WriteLine("****", Position);
            renderer.WriteLine("****", Position);
        }
    }
}
