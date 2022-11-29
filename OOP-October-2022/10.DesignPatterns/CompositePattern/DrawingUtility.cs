using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Drawables
{
    internal class DrawingUtility
    {
        public static void DrawMatrix(char[,] shape, Position position)
        {
            for (int row = 0; row < shape.GetLength(0); row++)
            {
                for (int col = 0; col < shape.GetLength(1); col++)
                {
                    Console.SetCursorPosition(position.Left + col, position.Top + row);
                    Console.Write(shape[row, col]);
                }
            }
        }
    }
}
