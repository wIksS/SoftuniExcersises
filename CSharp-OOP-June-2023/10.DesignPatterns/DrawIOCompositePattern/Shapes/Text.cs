using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    internal class Text : Shape
    {
        public Text(Position position, string text) : base(position)
        {
            Value = text;
        }

        public string Value { get; set; }
        public override void Draw()
        {
            Console.SetCursorPosition(Position.Col, Position.Row);
            Console.Write(Value);
            base.Draw();
        }
    }
}
