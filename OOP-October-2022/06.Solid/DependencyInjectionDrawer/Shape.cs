using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer
{
    internal abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = new ConsoleRenderer;
        }

        public int Top { get; set; }

        public int Left { get; set; }

        public abstract void Draw();
    }
}
