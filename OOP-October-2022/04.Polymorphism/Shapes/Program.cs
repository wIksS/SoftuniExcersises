using ShapesWithoutPolymorphism;
using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Shape: ");
                string shape = Console.ReadLine();

                Console.Write($"Size: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write($"Row: ");
                int row = int.Parse(Console.ReadLine());

                Console.Write($"Col: ");
                int col = int.Parse(Console.ReadLine());

                Console.Write($"Color: ");
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());


                if (shape == "Square")
                {
                    Square square = new Square(color, new Position(row, col), size);

                    square.ChangeColor(color);
                    square.SetStartPostiion();
                    square.Draw();
                    square.ResetColor();
                }

                if (shape == "Circle")
                {
                    Circle circle = new Circle(color, new Position(row, col), size);

                    //circle.ChangeColor(color);
                    circle.SetStartPostiion();
                    circle.Draw();
                    circle.ResetColor();
                }
                if (shape == "Elipsis")
                {
                    Circle circle = new Circle(color, new Position(row, col), size);

                    //circle.ChangeColor(color);
                    circle.SetStartPostiion();
                    circle.Draw();
                    circle.ResetColor();
                }

                if (shape == "Mnogoygylnik")
                {
                    Circle circle = new Circle(color, new Position(row, col), size);

                    //circle.ChangeColor(color);
                    circle.SetStartPostiion();
                    circle.Draw();
                    circle.ResetColor();
                }
                if (shape == "Circle")
                {
                    Circle circle = new Circle(color, new Position(row, col), size);

                    //circle.ChangeColor(color);
                    circle.SetStartPostiion();
                    circle.Draw();
                    circle.ResetColor();
                }
            }
        }
    }
}
