
using Renderers;
using Renderers.Renderers;
using Renderers.Renderers.Interfaces;

IRenderer renderer = new ConsoleRenderer();

Square square = new Square(new Position(5,15), renderer);
Circle circle = new Circle(new Position(9, 25), renderer);

square.Draw();

circle.Draw();