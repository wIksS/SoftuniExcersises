using CompositePattern.Drawables;
using System;
using System.Threading;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable page = new Drawable();

            IDrawable clouds = new Drawable();
            clouds.AddChild(new Cloud(new Position(5, 13)));
            clouds.AddChild(new Cloud(new Position(2, 34)));
            clouds.AddChild(new Cloud(new Position(15, 25)));


            IDrawable lines = new Drawable();

            lines.AddChild(new Line(new Position(0, 0)));
            lines.AddChild(new Line(new Position(25, 0)));
            lines.AddChild(new Line(new Position(28, 0)));


            page.AddChild(lines);
            page.AddChild(clouds);
            Random rand = new Random();


            while (true)
            {
                Console.Clear();
                page.Draw();
                clouds.Move(Direction.Left);
                lines.Move(Direction.Right);
                page.ChangeColor((ConsoleColor)rand.Next(0,15));

                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
