using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(6);

            List<IDrawable> drawableObjects = new List<IDrawable>();

            drawableObjects.Add(new NotDrawable());

            drawableObjects.Add(new Rectangle(6, 4));
            drawableObjects.Add(new Circle(5));
            drawableObjects.Add(new Rectangle(6, 4));
            drawableObjects.Add(new Circle(5));
            drawableObjects.Add(new Rectangle(6, 4));
            drawableObjects.Add(new Circle(5));
            drawableObjects.Add(new Rectangle(6, 4));
            drawableObjects.Add(new Circle(5));
            drawableObjects.Add(new Rectangle(6, 4));
            drawableObjects.Add(new Circle(5));

            foreach (var item in drawableObjects)
            {
                item.Draw();
            }
        }
    }
}
