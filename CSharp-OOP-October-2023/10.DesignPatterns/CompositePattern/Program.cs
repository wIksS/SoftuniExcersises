
using CompositePattern;
using CompositePattern.Shapes;

Shape page = new Shape(new Position(0, 0));

Shape leftPage = new Shape(new Position(0, 0));

Rectangle rectangle = new Rectangle(new Position(3, 13), 4, 7);
Line line = new Line(new Position(1, 10), 5);
Line line2 = new Line(new Position(1, 20), 5);

Line line3 = new Line(new Position(9, 10), 5);
Line line4 = new Line(new Position(9, 20), 5);

rectangle.AddChild(line);
rectangle.AddChild(line2);
rectangle.AddChild(line3);
rectangle.AddChild(line4);

leftPage.AddChild(rectangle);



Shape rightPage = new Shape(new Position(0, 0));

rectangle = new Rectangle(new Position(3, 13 + 20), 4, 7);
line = new Line(new Position(1, 10 + 20), 5);
line2 = new Line(new Position(1, 20 + 20), 5);

line3 = new Line(new Position(9, 10 + 20), 5);
line4 = new Line(new Position(9, 20 + 20), 5);

rectangle.AddChild(line);
rectangle.AddChild(line2);
rectangle.AddChild(line3);
rectangle.AddChild(line4);

rightPage.AddChild(rectangle);



page.AddChild(leftPage);
page.AddChild(rightPage);

rightPage.Color(ConsoleColor.Red);
leftPage.Color(ConsoleColor.Green);
page.Color(ConsoleColor.Blue);

while (true)
{
    Console.Clear();
    leftPage.Move(Direction.right);
    rightPage.Move(Direction.down);

    page.Draw();
    Thread.Sleep(200);
}

Console.ReadLine();