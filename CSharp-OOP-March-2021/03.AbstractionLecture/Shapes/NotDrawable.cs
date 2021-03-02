using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class NotDrawable : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Not drawing");
        }

        public void Something()
        {

        }
    }
}
