using System;

namespace SnakeGame.Helper
{
    public class BoundariesChecker
    {
        public static void CheckBoundaries(Position headPosition, Position movement)
        {
            var newHeadPosition = headPosition.GetNewPosition(movement);
            if (newHeadPosition.Y <= -1)
            {
                ConsoleHelper.Clear(headPosition);
                headPosition.Y = Console.WindowHeight - 1;
            }
            if (newHeadPosition.X <= -1)
            {
                ConsoleHelper.Clear(headPosition);
                headPosition.X = Console.WindowWidth - 1;
            }
            if (newHeadPosition.X >= Console.WindowWidth)
            {
                ConsoleHelper.Clear(headPosition);
                headPosition.X = 0;
            }
            if (newHeadPosition.Y >= Console.WindowHeight)
            {
                ConsoleHelper.Clear(headPosition);
                headPosition.Y = 0;
            }


        }
    }
}
