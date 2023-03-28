using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern.Components
{
    public class Rectangle : Component
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
            Console.ForegroundColor = color;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.SetCursorPosition(position.X + i, position.Y + j);
                    Console.Write("#");
                }
            }

            base.Draw();
        }
    }
}
