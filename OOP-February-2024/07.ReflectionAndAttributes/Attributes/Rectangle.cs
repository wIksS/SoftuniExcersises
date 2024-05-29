using Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Documentation]
    internal class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am a rectangle");
        }
    }
}
