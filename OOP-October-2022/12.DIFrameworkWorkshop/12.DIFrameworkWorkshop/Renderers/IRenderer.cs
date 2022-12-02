using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Renderers
{
    internal interface IRenderer
    {
        void Write(object obj);

        void WriteLine(object obj);
    }
}
