using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions
{
    internal class Drawer
    {
        public void Draw(string shapeType)
        {
            if (shapeType != "Square")
            {
                throw new ShapeNotDrawableException("I can only do square :(", shapeType);
            }

            Console.WriteLine("Square drawn!");
        }
    }
}
