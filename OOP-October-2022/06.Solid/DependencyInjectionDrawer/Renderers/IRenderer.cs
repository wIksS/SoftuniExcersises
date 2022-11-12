using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer.Renderers
{
    internal interface IRenderer
    {
        void Write(object text);

        void WriteLine(object text);

        void WriteAt(int y, int x);
    }
}
