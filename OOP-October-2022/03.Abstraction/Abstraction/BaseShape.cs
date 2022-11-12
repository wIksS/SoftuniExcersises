using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class BaseShape
    {
        protected IDrawer drawer;

        protected BaseShape(IDrawer drawer)
        {
            this.drawer = drawer;
        }

        public ConsoleColor Color { get; set; }

        public abstract void Draw();

        public void ChangeColor()
        {
            Console.ForegroundColor = Color;
        }
    }
}
