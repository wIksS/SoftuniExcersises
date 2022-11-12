using ShapesWithoutPolymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithPolymorphism
{
    public abstract class Shape
    {
        public Shape(ConsoleColor color, Position position, int size)
        {
            Color = color;
            Position = position;
            Size = size;
        }

        public ConsoleColor Color { get; set; }

        public Position Position { get; set; }

        public int Size { get; set; }

        public abstract void Draw();

        public void ChangeColor()
        {
            Console.ForegroundColor = Color;
        }

        public void SetStartPostiion()
        {
            Console.SetCursorPosition(Position.Left, Position.Top);
        }

        public void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
