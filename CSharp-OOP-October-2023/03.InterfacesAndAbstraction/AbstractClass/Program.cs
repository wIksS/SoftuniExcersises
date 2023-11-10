
Shape shape = new Circle(5,5);

shape.Draw();

abstract class Shape : IDisposable
{
    public Shape(int x, int y)
    {
        X = x;
        Y = y;
        Color = ConsoleColor.Green;
    }
    public ConsoleColor Color{ get; set; }

    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();

    public void ChangeColor()
    {
        Console.BackgroundColor = Color;
    }

    public abstract void Dispose();
}

class Circle : Shape
{
    public Circle(int x, int y) : base(x, y)
    {
    }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }

    public override void Draw()
    {
        ChangeColor();
        Console.WriteLine("Drawing Circle");
    }
}