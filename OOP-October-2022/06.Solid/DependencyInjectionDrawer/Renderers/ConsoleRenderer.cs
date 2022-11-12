using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDrawer.Renderers
{
    internal class ConsoleRenderer : IRenderer
    {
        public void Write(object text)
        {
            Console.Write(text);
        }

        public void WriteAt(int y, int x)
        {
            Console.SetCursorPosition(y, x);
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text);
        }
    }
}
