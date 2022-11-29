using CompositePattern.Drawables;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class Line : Shape
    {
        public Line(Position pos) : base(pos)
        {
            shape = new char[,]
            {
               {  '-','-','-','-','-' },
            };
        }

    }
}
