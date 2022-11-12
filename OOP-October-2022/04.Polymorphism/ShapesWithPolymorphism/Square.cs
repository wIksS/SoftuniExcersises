using ShapesWithPolymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithoutPolymorphism
{
    public class Square : Shape
    {
        public Square(ConsoleColor color, Position position, int size) : base(color, position, size) { }


        public int SquareSize { get; set; }

        public override void Draw()
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
