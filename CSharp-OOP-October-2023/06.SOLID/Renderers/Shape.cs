using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer, Position position)
        {
            Position = position;
            this.renderer = renderer;
        }

        public Position Position { get; set; }

        public abstract void Draw();
    }
}
