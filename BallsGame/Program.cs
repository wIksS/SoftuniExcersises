using InheritanceLecture.Conctract;
using InheritanceLecture.Renderers;
using System;
using System.Collections.Generic;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new TextRenderer("../../../game.txt");
            //IRenderer renderer = new ConsoleRenderer();

            Engine engine = new Engine(renderer);
            engine.Start();
        }
    }
}
