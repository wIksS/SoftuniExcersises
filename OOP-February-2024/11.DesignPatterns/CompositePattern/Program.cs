



using CompositePattern;
Shape page = new Shape(0, new Position(0, 0));

Shape figure = new Shape(0, new Position(0, 0));
Rectangle rectangle = new Rectangle(5, new Position(10, 10));
Rectangle rectangle2 = new Rectangle(8, new Position(22, 7));
Rectangle rectangle3 = new Rectangle(5, new Position(40, 10));


figure.AddChild(rectangle);
figure.AddChild(rectangle2);
figure.AddChild(rectangle3);

Shape figure2 = new Shape(0, new Position(0, 0));

Line line1 = new Line(8, new Position(2, 2));
Line line2 = new Line(8, new Position(17, 2));
Line line3 = new Line(8, new Position(10, 4));

figure2.AddChild(line1);
figure2.AddChild(line2);
figure2.AddChild(line3);

page.AddChild(figure);
page.AddChild(figure2);

while (true)
{
    Console.Clear();
    figure.Move(Direction.Right);
    page.Draw();
    figure2.Move(Direction.Down);

    Thread.Sleep(200);
}