using SnakeGame.Helper;
using SnakeGame.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class Food : IDrawable
    {
        private bool isEaten = false;

        public Food(Position position, char symbol = '#')
        {
            this.Symbol = symbol;
            this.Position = position;
        }
        public Position Position { get; set; }

        public char Symbol { get; set; }

        public void EatFood()
        {
            ConsoleHelper.Clear(Position);
            isEaten = true;
        }

        public void Draw()
        {
            if (isEaten == false)
            {
                ConsoleHelper.Write(Position, Symbol.ToString());
            }
        }
    }
}
