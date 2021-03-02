using InheritanceLecture.Conctract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    class Racket : GameObject
    {
        public Racket(int size, Position position, IRenderer renderer)
            :base(position, renderer)
        {
            Size = size;
        }

        public int Size { get; set; }

        public override void Draw()
        {
            for (int i = 0; i < Size; i++)
            {
                Renderer.WriteAtPosition("|", new Position(Position.X+i, Position.Y));
            }
        }
    }
}
