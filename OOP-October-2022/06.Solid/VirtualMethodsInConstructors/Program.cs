using System;

namespace VirtualMethodsInConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
        }
    }

    class Shape
    {
        public Shape()
        {
            Console.WriteLine("In Shape");
            Draw();
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing all the borders");
        }
    }

    class Circle: Shape
    {
        string title;
        public Circle()
        {
            title = "Circle";
            Console.WriteLine("In Circle");
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing the circle {title.ToLower()}"); 
        }
    }
}
