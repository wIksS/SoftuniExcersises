using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    internal class TextRenderer : IRenderer
    {
        private string path;
        public TextRenderer(string path)
        {
            this.path = path;
            File.Delete(path);
        }
        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
