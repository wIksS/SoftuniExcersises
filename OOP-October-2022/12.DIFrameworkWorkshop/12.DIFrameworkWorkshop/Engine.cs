using _12.DIFrameworkWorkshop.Common;
using _12.DIFrameworkWorkshop.Drawers.Contracts;
using _12.DIFrameworkWorkshop.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop
{
    class Engine
    {
        private IShapeDrawer drawer;
        private List<Shape> shapes;
        private ILogger logger;

        public Engine(IShapeDrawer drawer, IDateLogger logger)
        {
            this.drawer = drawer;
            shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            this.logger = logger;
        }

        public void Run()
        {
            foreach (var shape in shapes)
            {
                logger.Log($"ENGINE: drawing shape: {shape}");
                if (shape is Circle)
                {
                    drawer.DrawCircle(shape as Circle);
                }
                if (shape is Rectangle)
                {
                    drawer.DrawRectangle(shape as Rectangle);
                }
            }
        }
    }
}
