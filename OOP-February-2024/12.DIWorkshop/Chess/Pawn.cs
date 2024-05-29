using Chess.Drawers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Pawn
    {
        private IDrawer drawer;

        public Pawn(IDrawer drawer)
        {
            this.drawer = drawer;
        }

        public void Draw()
        {
            drawer.Write("P");
        }
    }
}
