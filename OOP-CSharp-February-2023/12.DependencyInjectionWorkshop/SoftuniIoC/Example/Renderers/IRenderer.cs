using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDependencyInversion.Renderers
{
    public interface IRenderer
    {
        void Write(object msg);

        void WriteLine(object msg);

        void Clear();
    }
}
