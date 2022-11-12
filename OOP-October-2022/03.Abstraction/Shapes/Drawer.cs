using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shapes
{
    public class Drawer
    {
        private List<IDrawable> drawables;

        public Drawer(List<IDrawable> drawables)
        {
            this.drawables = drawables;
        }

        public void Draw()
        {
            int left = 0;
            int top = 0;
            while (true)
            {
                Console.Clear();

                top = 0;
                foreach (IDrawable drawable in drawables)
                {
                    top += 5;
                    Console.SetCursorPosition(left++, top);
                    drawable.Draw();
                }

                Thread.Sleep(500);
            }
        }
    }
}
