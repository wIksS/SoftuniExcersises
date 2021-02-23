using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    class GameObject
    {
        public Position Position { get; set; }

        public GameObject(Position startingPosition)
        {
            Position = startingPosition;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing at {Position.X}:{Position.Y}");
        }
    }
}
