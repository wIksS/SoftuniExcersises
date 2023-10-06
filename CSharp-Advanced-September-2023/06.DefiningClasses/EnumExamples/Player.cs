using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    internal class Player
    {
        public Player()
        {
            Direction = Direction.Right;
        }
        public Direction Direction { get; set; }
    }
}
