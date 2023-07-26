
using DrawIOCompositePattern;

Shape page = new Shape(new Position(0, 0));

Shape leftAd = new Shape(new Position(0, 0));
Rectangle leftRectangle = new Rectangle(new Position(10, 5), 20, 5);
Line leftLine = new Line(new Position(15, 5), 30);
Text leftText = new Text(new Position(17, 5), "Left ad is best!");
Line leftLine2 = new Line(new Position(19, 5), 30);

leftAd.AddChild(leftLine);
leftAd.AddChild(leftText);
leftAd.AddChild(leftLine2);
leftAd.AddChild(leftRectangle);

Shape rightAd = new Shape(new Position(0, 0));
Rectangle rightRec = new Rectangle(new Position(10, 55), 20, 5);
Line rightLine = new Line(new Position(15, 55), 30);
Text rightText = new Text(new Position(17, 55), "Right ad is better than left!");
Line rightLine2 = new Line(new Position(19, 55), 30);

rightAd.AddChild(rightRec);
rightAd.AddChild(rightLine2);
rightAd.AddChild(rightText);
rightAd.AddChild(rightLine);

page.AddChild(leftAd);
//page.AddChild(rightAd);

leftAd.ChangeColor(ConsoleColor.Cyan);
rightAd.ChangeColor(ConsoleColor.Magenta);

while (true)
{
    Thread.Sleep(200);
    leftAd.Move(Direction.Right);
    rightAd.Move(Direction.Left);
    Console.Clear();
    page.Draw();
}