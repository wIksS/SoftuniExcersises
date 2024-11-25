
using CompositePattern;

Shape page = new Shape(null);

Shape left = new Shape(null);

left.Children.Add(new Text(new Position(2, 9), "Left Drawing!"));
left.Children.Add(new Square(new Position(5,4),4,8));
left.Children.Add(new Square(new Position(5, 16), 4, 8));
left.Children.Add(new Square(new Position(10, 9), 4, 8));

Shape right = new Shape(null);

right.Children.Add(new Text(new Position(2, 69), "Right Drawing!"));

right.Children.Add(new Square(new Position(5, 60+4), 4, 8));
right.Children.Add(new Square(new Position(5, 60+16), 4, 8));
right.Children.Add(new Square(new Position(10,60+ 9), 4, 8));
right.Children.Add(new Line(new Position(13,  60 + 9), 14));

page.Children.Add(left);
page.Children.Add(right);


left.ChangeColor(ConsoleColor.Cyan);
right.ChangeColor(ConsoleColor.Magenta);

right.Children[2].ChangeColor(ConsoleColor.Yellow);

page.Draw();

//page.ChangeColor(ConsoleColor.Cyan);
Random random = new Random();
while (true)
{
    Thread.Sleep(50);
    Console.Clear();
    page.Move(Direction.down);
    right.Move(Direction.left);

    left.ChangeColor((ConsoleColor)random.Next(0, 15));
    right.ChangeColor((ConsoleColor)random.Next(0, 15));
    //right.Move(Direction.left);

    page.Draw();

}