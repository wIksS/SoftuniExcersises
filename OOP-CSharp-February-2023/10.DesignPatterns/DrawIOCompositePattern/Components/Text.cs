using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    public class Text : Component
    {
        public Text(Position position, string words) : base(position)
        {
            Words = words;
        }

        public string Words { get; set; }

        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(Words);
            base.Draw();
        }
    }
}
