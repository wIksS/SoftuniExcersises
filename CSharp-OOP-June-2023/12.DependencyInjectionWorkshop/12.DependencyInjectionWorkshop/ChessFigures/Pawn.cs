using _12.DependencyInjectionWorkshop.Contracts;
using _12.DependencyInjectionWorkshop.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    internal class Pawn : IDrawable
    {
        private IRenderer renderer;

        public Pawn(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public void Draw()
        {
            renderer.Write("P");
        }
    }
}
