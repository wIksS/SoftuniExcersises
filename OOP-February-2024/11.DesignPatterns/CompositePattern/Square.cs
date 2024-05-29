using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Square : Shape
    {
        public Square(int size, Position position) : base(size, position)
        {
        }

        public override void Draw()
        {
            base.Draw();

            Console.SetCursorPosition(Position.X, Position.Y);

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("#");
                }

                Console.SetCursorPosition(Position.X, Position.Y + i);
            }
        }
    }
}
