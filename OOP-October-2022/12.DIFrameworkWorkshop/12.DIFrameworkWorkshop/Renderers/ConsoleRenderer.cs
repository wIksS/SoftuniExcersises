using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Renderers
{
    internal class ConsoleRenderer : IRenderer
    {
        public void Write(object obj)
        {
            Console.Write(obj);
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
