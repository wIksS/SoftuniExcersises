using P02._DrawingShape_Before.Drawers;
using System;

namespace P02._DrawingShape_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager drawer = new DrawingManager();

            Player player = new Player();
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();

            drawer.Draw(player);
            drawer.Draw(rec);
            drawer.Draw(circle);

            drawer.Draw(new Line());
        }
    }
}
