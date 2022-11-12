using Abstraction.Drawers;
using System;
using System.Collections.Generic;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDrawer drawer = new ConsoleDrawer();
            //IDrawer drawer = new FileDrawer("../../../painting.txt");

            drawer.WriteLine("Hello");

            //drawer.WriteAtPosition(16,50,"Hello at middle");

            Circle circle = new Circle(drawer, 5);
            circle.Color = ConsoleColor.Green;
            Rectangle rectangle = new Rectangle(drawer, 7, 8, 20, 20);
            rectangle.Color = ConsoleColor.Yellow;
            Line line = new Line(drawer, 25);
            List<BaseShape> shapes = new List<BaseShape>()
            { circle,rectangle,line};

            foreach (BaseShape shape in shapes)
            {
                shape.ChangeColor();
                shape.Draw();
            }

        }
    }
}
