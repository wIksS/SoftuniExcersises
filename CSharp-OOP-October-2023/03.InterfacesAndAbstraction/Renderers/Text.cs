using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    internal class Text : IShape
    {
        private IRenderer renderer;
        private string text;

        public Text(IRenderer renderer, string text)
        {
            this.renderer = renderer;
            this.text = text;
        }
        public void Draw()
        {
            renderer.WriteLine(text);
        }
    }
}
