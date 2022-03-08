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
            double minutes = 210;


            while (true)
            {
                var passedMinutes = DateTime.Now - new DateTime(2022, 3, 1, 18, 0, 0);
                Console.Clear();
                Console.WriteLine((int)(passedMinutes.TotalMinutes/minutes*100) + "%");
                Thread.Sleep(100);
                //passedMinutes++;
            }

            List<IDrawable> drawableObjects = new List<IDrawable>();

            drawableObjects.Add(new Bird());
            drawableObjects.Add(new Column());

            IDrawer drawer = new TextDrawer("../../../game.txt");

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
