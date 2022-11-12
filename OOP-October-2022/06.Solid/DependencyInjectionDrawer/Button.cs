using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer
{
    internal class Button
    {
        public IRenderer Renderer { get; set; }

        public void Draw()
        {
            Renderer.WriteLine("Button");
        }
    }
}
