using _12.DIFrameworkWorkshop.Common;
using _12.DIFrameworkWorkshop.Drawers.Contracts;
using _12.DIFrameworkWorkshop.Renderers;
using _12.DIFrameworkWorkshop.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Drawers
{
    internal class AdvancedShapeDrawer : BasicShapeDrawer
    {
        private ILogger logger;
        public AdvancedShapeDrawer(IRenderer renderer, ILogger logger) : base(renderer)
        {
            this.logger = logger;
        }

        public override void DrawCircle(Circle circle)
        {
            logger.Log("Drawing Circle!");
            Console.WriteLine($"  @@");
            Console.WriteLine($"@    @");
            Console.WriteLine($"@    @");
            Console.WriteLine($"  @@");
        }

        public override void DrawRectangle(Rectangle rectangle)
        {
            logger.Log("Drawing Rectangle!");

            Console.WriteLine("@@@@");
            Console.WriteLine("@  @");
            Console.WriteLine("@  @");
            Console.WriteLine("@@@@");
        }
    }
}
