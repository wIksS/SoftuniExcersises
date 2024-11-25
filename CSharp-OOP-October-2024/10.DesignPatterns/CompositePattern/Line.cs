using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Line : Shape
    {
        public Line(Position position, int length) : base(position)
        {
            Length = length;
        }

        public int Length { get; set; }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.Left, Position.Top);

            for (int i = 0; i < Length; i++)
            {
                Console.Write("-");
            }

            base.Draw();
        }
    }
}
