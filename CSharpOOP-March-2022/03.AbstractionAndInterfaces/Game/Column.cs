using Game.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Column : IDrawable
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Hitting birds");
        }
    }
}
