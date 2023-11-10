using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    internal class Circle : IShape
    {
        private IRenderer renderer;

        public Circle(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public void Draw()
        {
            renderer.WriteLine("   *   ");
            renderer.WriteLine("  ***  ");
            renderer.WriteLine(" ***** ");
            renderer.WriteLine("  *** ");
            renderer.WriteLine("   * ");
        }
    }
}
