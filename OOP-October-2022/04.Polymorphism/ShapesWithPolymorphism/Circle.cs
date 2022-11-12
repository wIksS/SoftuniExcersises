using ShapesWithPolymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesWithoutPolymorphism
{
    public class Circle : Shape
    {
        public Circle(ConsoleColor color, Position position, int size) : base(color, position, size) { }

        public int CircleSize { get; set; }

        public void HiCircle()
        {
            Console.WriteLine("Hi from Circle!");
        }

        public override void Draw()
        {
            double radius = Size;
            double thickness = 0.4;
            char symbol = '*';

            double rIn = radius - thickness, rOut = radius + thickness;
            Console.WriteLine();
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol.ToString());
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
