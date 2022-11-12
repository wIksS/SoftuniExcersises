using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;

namespace DependencyInjectionDrawer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer();

            Button button = new Button();

            button.Renderer = renderer;
            button.Draw();
            button.Renderer = new HtmlRenderer();
            button.Draw();
            button.Renderer = renderer;
            button.Draw();


            return;

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(renderer));
            shapes.Add(new Square(renderer));

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
