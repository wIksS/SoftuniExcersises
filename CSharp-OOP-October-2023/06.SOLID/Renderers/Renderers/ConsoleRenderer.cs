using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        public void Write(string text, Position position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            position.Y++;
            Console.Write(text);
        }

        public void WriteLine(string text, Position position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            position.Y++;

            Console.WriteLine(text);
        }
    }
}
