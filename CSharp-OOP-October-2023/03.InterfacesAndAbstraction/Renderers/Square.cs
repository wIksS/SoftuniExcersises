using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    internal class Square : IShape
    {
        private IRenderer renderer;

        public Square(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public void Draw()
        {
            renderer.WriteLine("*********");
            renderer.WriteLine("*       *");
            renderer.WriteLine("*       *");
            renderer.WriteLine("*       *");
            renderer.WriteLine("*********");
        }
    }
}
