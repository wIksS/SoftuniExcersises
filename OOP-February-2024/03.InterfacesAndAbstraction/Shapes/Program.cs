using Shapes;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            List<IDrawable> drawables = new List<IDrawable>();
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            drawables.Add(circle);
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            drawables.Add(rect);
            drawables.Add(circle);


            foreach (var drawable in drawables)
            {
                drawable.Draw();
            }

        }
    } 
}

   