using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithoutPolymorphism
{
    public class Square
    {
        public Square(ConsoleColor color, Position position, int size)
        {
            Color = color;
            Position = position;
            Size = size;
        }

        public ConsoleColor Color { get; set; }

        public Position Position { get; set; }

        public int Size { get; set; }

        public void ChangeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void SetStartPostiion()
        {
            Console.SetCursorPosition(Position.Left, Position.Top);
        }

        public void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }


        public void Draw()
        {
            DrawLine(this.Size, '*', '*');
            for (int i = 1; i < this.Size - 1; ++i)
                DrawLine(this.Size, '*', ' ');
            DrawLine(this.Size, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }
    }
}
