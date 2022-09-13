using Game.Contracts;
using Game.Drawers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IDrawable> drawableObjects = new List<IDrawable>();

            drawableObjects.Add(new Bird());
            drawableObjects.Add(new Column());

            IDrawer drawer = new ConsoleDrawer();

            // flappy bird
            while (true)
            {
                Thread.Sleep(1000);
                foreach (var drawable in drawableObjects)
                {
                    drawable.Draw(drawer);
                }
            }
        }
    }
}
