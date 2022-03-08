using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class Shape
    {
        private int drawCount = 0;
        private int maxDrawCount = 100;
        private int x=25;
        private int y=10;

        public virtual void Draw()
        {
            if (CanDrawShape())
            {
                Console.SetCursorPosition(y, x);
                Console.WriteLine($"Drawing shape! with size {6}");
            }
        }

        private bool CanDrawShape()
        {
            drawCount++;
            if (drawCount > maxDrawCount)
            {
                Console.WriteLine("Too many shapes");
                return false;
            }

            return true;
        }
    }
}
