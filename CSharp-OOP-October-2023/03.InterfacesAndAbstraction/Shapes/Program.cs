

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            IDrawable circle = new Circle(5);

            IDrawable rectangle = new Rectangle(5, 7);

            
            circle.Draw();

            rectangle.Draw();
        }
    }
}