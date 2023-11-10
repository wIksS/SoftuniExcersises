using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    internal interface IRenderer
    {
        public void Write(string text);
        public void WriteLine(string text);
    }
}
