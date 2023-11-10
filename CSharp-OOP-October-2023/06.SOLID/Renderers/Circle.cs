using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    internal class Circle : Shape
    {
        public Circle(IRenderer renderer, Position position) : base(renderer, position)
        {
        }

        public override void Draw()
        {
            renderer.WriteLine(" ** ", Position);
            renderer.WriteLine("*  *", Position);
            renderer.WriteLine("*  *", Position);
            renderer.WriteLine(" ** ", Position);
        }
    }
}
