using Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Line : IDrawable
    {
        private int size;

        public Line(int size)
        {
            this.size = size;
        }

        public void Draw()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}
