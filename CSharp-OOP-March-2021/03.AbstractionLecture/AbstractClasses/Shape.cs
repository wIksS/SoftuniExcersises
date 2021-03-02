using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class Shape : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        public virtual void PrintName()
        {
            Console.WriteLine("Printing name of shape: Shape");
        }
    }
}
