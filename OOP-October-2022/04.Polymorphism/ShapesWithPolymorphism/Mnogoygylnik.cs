using ShapesWithoutPolymorphism;
using System;

namespace ShapesWithPolymorphism
{
    internal class Mnogoygylnik : Shape
    {
        public Mnogoygylnik(ConsoleColor color, Position position, int size) : base(color, position, size)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Mnogoygylnik");
        }
    }
}