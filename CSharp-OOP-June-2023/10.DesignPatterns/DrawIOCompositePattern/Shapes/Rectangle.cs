using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    internal class Rectangle : Shape
    {
        public Rectangle(Position position, int width, int height) : base(position)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.SetCursorPosition(Position.Col + j, Position.Row + i);
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            base.Draw();
        }
    }
}
