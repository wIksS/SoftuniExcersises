using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class BaseShape
    {
        public int Top { get; set; }
        public int Left { get; set; }

        public abstract void Draw();
    }
}
