using _12.DIFrameworkWorkshop.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Drawers.Contracts
{
    internal interface IShapeDrawer
    {
        public void DrawCircle(Circle circle);

        public void DrawRectangle(Rectangle rectangle);
    }
}
