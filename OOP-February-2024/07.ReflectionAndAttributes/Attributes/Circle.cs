using Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Documentation]
    internal class Circle : Shape
    {
        [Documentation]
        public override void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
}
