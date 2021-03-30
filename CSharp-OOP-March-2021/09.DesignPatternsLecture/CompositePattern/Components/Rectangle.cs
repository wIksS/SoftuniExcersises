using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Components
{
    class Rectangle : Component
    {
        public Rectangle(Position position, int size): base(position)
        {
            Size = size;
        }

        public int Size { get; set; }

        public override void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("@");
                }

                Console.SetCursorPosition(Position.X, Position.Y + i);
            }

            base.Draw();
        }
    }
}
