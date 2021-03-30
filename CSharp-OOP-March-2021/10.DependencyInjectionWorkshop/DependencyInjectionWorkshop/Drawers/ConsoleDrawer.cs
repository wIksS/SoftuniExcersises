using DependencyInjectionWorkshop.Common;
using DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Drawers
{
    class ConsoleDrawer : IDrawer
    {
        public void DrawAtPosition(Position position, string toDraw)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(toDraw);
        }
    }
}
