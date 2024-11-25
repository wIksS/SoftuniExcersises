using Renderers.Renderers;
using Renderers.Renderers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    public class Square
    {
        private IRenderer renderer;

        public Square(Position position, IRenderer renderer)
        {
            renderer = new PinkRenderer();
            this.Position = position;
            this.renderer = renderer;
        }

        public int Size { get; set; }

        public Position Position { get; set; }

        public void Draw()
        {
            renderer.Render("Square", Position);
        }

        public void DrawCircle()
        {
            renderer.Render("Circle", Position);
        }
    }
}
