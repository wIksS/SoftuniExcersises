using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    public class Position
    {        public Position(int top, int left)
        {
            Top = top;
            Left = left;
        }

        public int Top { get; set; }

        public int Left { get; set; }
    }
}
