using Game.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Bird : IDrawable
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Flapping");
        }
    }
}
