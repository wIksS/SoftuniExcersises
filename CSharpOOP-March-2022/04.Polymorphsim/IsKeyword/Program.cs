using System;

namespace IsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            const int min = 100;
            const int min1 = 100;
            int rand = new Random().Next();
            if (!(rand is max or min or min1))
            {
                Console.WriteLine(5);
            }

            Shape shape=null;
            if (shape is null)
            {
                Console.WriteLine("null shape");
            }
            if (new Random().Next()% 2== 0)
            {
                shape = new Circle();
            }
            else
            {
                shape = new Rectangle();
            }

            //Rectangle rec = shape as Rectangle;
            //Circle cir = shape as Circle;
            //Console.WriteLine(cir.Radius);
            shape.Draw();

            if (shape is Circle circle)
            {
                //Circle circle = (Circle)shape;
                int radius = circle.Radius;// ((Circle)shape);

                Console.WriteLine($"Radius: {radius}");
            }
        }
    }
}
