using ShapesWithoutPolymorphism;
using System;

namespace ShapesWithPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Shape: ");
                string type = Console.ReadLine();

                Console.Write($"Size: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write($"Row: ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Col: ");
                int col = int.Parse(Console.ReadLine());

                Console.Write($"Color: ");
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());

                Shape shape = null;

                if (type == "Circle")
                {
                    shape = new Circle(color, new Position(row, col), size);
                }
                if (type == "Square")
                {
                    shape = new Square(color, new Position(row, col), size);
                }
                if (type == "Elipsis")
                {
                    shape = new Elipsis(color, new Position(row, col), size);
                }
                if (type == "Mnogoygylnik")
                {
                    shape = new Mnogoygylnik(color, new Position(row, col), size);
                }

                shape.ChangeColor();
                shape.SetStartPostiion();
                shape.Draw();
                shape.ResetColor();

 
                if (shape is Circle)
                {
                    ((Circle)shape).HiCircle();

                    Circle circle = (Circle)shape;
                    circle.HiCircle();
                }
                if (shape is Square)
                {

                }
            }
        }
    }
}
