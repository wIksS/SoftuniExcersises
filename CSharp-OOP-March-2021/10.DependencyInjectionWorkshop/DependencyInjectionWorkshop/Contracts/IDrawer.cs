using DependencyInjectionWorkshop.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Contracts
{
    interface IDrawer
    {
        void DrawAtPosition(Position position, string toDraw);
    }
}
