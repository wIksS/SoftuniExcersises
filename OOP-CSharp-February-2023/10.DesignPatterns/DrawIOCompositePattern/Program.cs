

using DrawIOCompositePattern;
using DrawIOCompositePattern.Components;

Component page = new Component(new Position(0,0));  



Rectangle rectangle = new Rectangle(new Position(35,5),10,4);
Line line = new Line(new Position(35, 4));
rectangle.AddChild(line);
Text text = new Text(new Position(35, 3), "Neveroqtno");
rectangle.AddChild(text);


Cloud cloud = new Cloud(new Position(1,3));

Text cloudText = new Text(new Position(1, 1), "Tova e oblak :(");
Line textLine = new Line(new Position(1, 2));
cloudText.AddChild(textLine);

cloud.AddChild(cloudText);

page.AddChild(rectangle);
page.AddChild(cloud);


for (int i = 0; i < 10; i++)
{
    rectangle.Move(Direction.down);
    rectangle.Move(Direction.right);
}
rectangle.Color(ConsoleColor.Green);
cloud.Color(ConsoleColor.Cyan);

page.Draw();
Random random = new Random();

while (true)
{
    Console.Clear();

    rectangle.Move(Direction.left);
    cloud.Move(Direction.right);

    cloudText.Color((ConsoleColor)random.Next(0, 15));

    page.Draw();

    Thread.Sleep(300);
}