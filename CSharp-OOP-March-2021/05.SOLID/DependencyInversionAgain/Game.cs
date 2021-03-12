using DependencyInversionAgain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionAgain
{
    class Game
    {
        private IWriter writer;

        public Game(IWriter writer)
        {
            this.writer = writer;
        }

        public void DrawCircle()
        {
            Writer.Write($"  *");
            Writer.Write($"*   *");
            Writer.Write($"  *");
        }
    }
}
