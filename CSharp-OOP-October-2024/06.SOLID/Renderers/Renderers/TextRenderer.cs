using Renderers.Renderers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    public class TextRenderer : IRenderer
    {
        private string path = "../../../output.txt";
        private StreamWriter writer;

        public TextRenderer()
        {
            writer = new StreamWriter(path, true);
        }

        public void Render(string text, Position position)
        {
            writer.Write(text);
        }

    }
}
