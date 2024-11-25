using Renderers.Renderers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    public class PinkRenderer : IRenderer
    {
        public void Render(string text, Position position)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(position.Left, position.Top);
            Console.Write($"<html>{text}</html>");
        }

    }
}
