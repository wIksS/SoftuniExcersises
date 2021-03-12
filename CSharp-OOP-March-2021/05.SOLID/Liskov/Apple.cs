using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Green";
        }
    }
}
