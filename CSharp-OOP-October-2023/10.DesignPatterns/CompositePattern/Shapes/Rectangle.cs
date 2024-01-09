using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(Position position, int height, int width) : base(position)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public override void Draw()
        {
            base.Draw();


            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    SetCursorPosition(j,i);
                    Console.Write("#");
                }

            }
        }
    }
}
