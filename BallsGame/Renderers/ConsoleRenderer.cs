using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteAtPosition(string message, Position position)
        {
            Console.SetCursorPosition(position.Y, position.X);
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
