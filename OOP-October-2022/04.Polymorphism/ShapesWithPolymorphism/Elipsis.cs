using ShapesWithoutPolymorphism;
using System;

namespace ShapesWithPolymorphism
{
    internal class Elipsis : Shape
    {
        public Elipsis(ConsoleColor color, Position position, int size) : base(color, position, size)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Elipsis");
        }
    }
}