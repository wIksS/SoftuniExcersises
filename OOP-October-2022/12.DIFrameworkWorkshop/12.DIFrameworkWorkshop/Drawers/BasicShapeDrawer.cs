using _12.DIFrameworkWorkshop.Drawers.Contracts;
using _12.DIFrameworkWorkshop.Renderers;
using _12.DIFrameworkWorkshop.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Drawers
{
    internal class BasicShapeDrawer : IShapeDrawer
    {
        private readonly IRenderer renderer;

        public BasicShapeDrawer(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public virtual void DrawCircle(Circle circle)
        {
            renderer.WriteLine($@"  **");
            renderer.WriteLine($@"*    *");
            renderer.WriteLine($@"*    *");
            renderer.WriteLine($@"  **");
        }

        public virtual void DrawRectangle(Rectangle rectangle)
        {
            renderer.WriteLine("****");
            renderer.WriteLine("*  *");
            renderer.WriteLine("*  *");
            renderer.WriteLine("****");
        }
    }
}
