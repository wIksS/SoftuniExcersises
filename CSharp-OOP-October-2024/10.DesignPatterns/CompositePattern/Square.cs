using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Square : Shape
    {
        public Square(Position position, int a, int b) : base(position)
        {
            A = a;
            B = b;
        }

        public int A { get; set; }
        public int B { get; set; }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.Left, Position.Top);

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("*");
                }

                Console.SetCursorPosition(Position.Left, Position.Top + i);
            }

            base.Draw();
        }
    }
}
