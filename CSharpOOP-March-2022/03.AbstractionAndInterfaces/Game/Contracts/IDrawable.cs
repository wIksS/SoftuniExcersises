using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Contracts
{
    interface IDrawable
    {
        void Draw(IDrawer drawer);
    }
}
