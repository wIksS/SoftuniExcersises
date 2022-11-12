using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleLiskov
{
    internal class Rectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
