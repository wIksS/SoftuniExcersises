using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class ConsoleDrawer : IDrawer
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteAtPosition(int row, int col, string text)
        {
            Console.SetCursorPosition(col, row);
            Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public int BufferHeight { get { return Console.BufferHeight; }}

        public void ChangeColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}
