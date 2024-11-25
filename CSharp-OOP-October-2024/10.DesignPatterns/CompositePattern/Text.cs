using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Text : Shape
    {
        public Text(Position position, string value) : base(position)
        {
            Value = value;
        }

        public string Value { get; set; }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.Left, Position.Top);

            Console.Write(Value);

            base.Draw();
        }
    }
}
