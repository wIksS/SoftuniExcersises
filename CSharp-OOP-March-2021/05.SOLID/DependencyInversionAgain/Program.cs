using System;

namespace DependencyInversionAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //game.Writer = new ConsoleWriter();
            game.DrawCircle();
        }
    }
}
