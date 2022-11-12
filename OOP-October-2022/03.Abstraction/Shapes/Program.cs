using Abstraction;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawables = new List<IDrawable>();

            drawables.Add(new Circle(5));
            drawables.Add(new Line(6));
            drawables.Add(new Rectangle(4,5));
            drawables.Add(new Line(9));
            drawables.Add(new Line(1));
            drawables.Add(new Line(24));
            drawables.Add(new Square());

            Drawer drawer = new Drawer(drawables);

            drawer.Draw();
        }
    }
}
