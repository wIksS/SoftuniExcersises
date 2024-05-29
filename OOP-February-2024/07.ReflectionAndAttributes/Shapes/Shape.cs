using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a shape");
        }
    }
}
