using System;
using System.Collections.Generic;
using System.Text;

namespace RedBlackTress
{
    public class Node
    {
        public Color Color { get; set; }

        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node Parent { get; set; }

        public void Recolor()
        {
            Color = (Color)((int)Color * -1);
        }

        public override string ToString()
        {
            if (Color == Color.Black)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (Color == Color.Red)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return $"{Value}P:{Parent?.Value}";
        }
    }

    public enum Color
    {
        Red = 1,
        Black = -1
    }
}
