
using Renderers;
using Renderers.Renderers;

IRenderer renderer = new TextRenderer("../../../output.txt");
//IRenderer renderer = new ConsoleRenderer();
List<IShape> shapes = new List<IShape>();

shapes.Add(new Circle(renderer));
shapes.Add(new Circle(renderer));
shapes.Add(new Square(renderer));
shapes.Add(new Circle(renderer));
shapes.Add(new Square(renderer));
shapes.Add(new Text(renderer, "Hello"));
shapes.Add(new Text(renderer, "How are you"));

foreach (var shape in shapes)
{
    shape.Draw();
}
