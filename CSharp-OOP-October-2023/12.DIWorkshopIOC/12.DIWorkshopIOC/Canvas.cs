using _12.DIWorkshopIOC.DI;
using _12.DIWorkshopIOC.Loggers;
using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    public class Canvas
    {
        private List<Shape> shapes;
        private ILogger logger;

        public Canvas(IRenderer renderer, ILogger logger)
        {
            this.logger = logger;
            IRenderer newRenderer = DIProvider.GetServiceProvider().GetRequiredService<IRenderer>();

            shapes = new List<Shape>();
            shapes.Add(new Circle(renderer, new Position(0, 0)));
            shapes.Add(new Rectangle(renderer, new Position(6, 0)));
            shapes.Add(new Circle(renderer, new Position(0, 6)));
            shapes.Add(new Rectangle(renderer, new Position(6, 6)));
        }

        public void Draw()
        {
            foreach (var shape in shapes)
            {
                logger.Log("Drawing: " + typeof(Shape));
                shape.Draw();
            }
        }
    }
}
