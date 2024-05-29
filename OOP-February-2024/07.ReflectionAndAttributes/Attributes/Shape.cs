using Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [Documentation(MoreInfo = "Base class for all shapes")]
    internal class Shape
    {
        [Documentation]
        public virtual void Draw()
        {
            Console.WriteLine("I am a shape");
        }

        [Documentation]
        public virtual void Draw2()
        {
            Console.WriteLine("I am a shape");
        }
        [Documentation]
        public virtual void Draw3()
        {
            Console.WriteLine("I am a shape");
        }

        [Documentation]
        public int Size { get; set; }
    }
}
