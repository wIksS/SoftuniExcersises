using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDependencyInversion.Renderers
{
    public class WebRenderer : IRenderer
    {
        private TextRenderer textRenderer = new TextRenderer("../../../chess.html");


        public void Clear()
        {
            textRenderer.Clear();
        }

        public void Write(object msg)
        {
            textRenderer.Write($"<span style=\"height: 100px; background: green; \">{msg}</span>");
        }

        public void WriteLine(object msg)
        {
            textRenderer.Write($"<div style=\"height: 50px; background: red; \">{msg}</div>");
        }
    }
}
