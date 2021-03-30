using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Components
{
    class Text : Leaf
    {
        public Text(Position position, string text): base(position)
        {
            TextToDraw = text;
        }

        public string TextToDraw { get; set; }


        public override void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(TextToDraw);

            base.Draw();
        }
    }
}
