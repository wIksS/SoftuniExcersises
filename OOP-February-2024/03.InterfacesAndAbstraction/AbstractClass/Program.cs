
Shape shape = new Circle();

abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }


    public abstract void Draw();

    public void PrintPosition()
    {
        Console.WriteLine($"X:{X},Y:{Y}");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        throw new NotImplementedException();
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        throw new NotImplementedException();
    }
}