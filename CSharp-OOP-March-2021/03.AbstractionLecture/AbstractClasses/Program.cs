using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle();
            Shape circle = new Circle();

            shape.Draw();
            shape.PrintName();

            circle.Draw();
            circle.PrintName();

            IDrawable p = new Paralelepiped();

            PrintObjects(new Circle());
        }

        static void PrintObjects(IDrawable objectToDraw)
        {
            objectToDraw.Draw();
        }
    }
}
