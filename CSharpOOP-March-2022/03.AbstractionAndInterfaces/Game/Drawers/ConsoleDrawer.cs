using Game.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Drawers
{
    class ConsoleDrawer : IDrawer
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteAt(string message, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            
            Console.WriteLine(message);
        }
    }
}
