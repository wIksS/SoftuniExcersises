using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers.Interfaces
{
    public interface IRenderer
    {
        void Render(string text, Position position);
    }
}
