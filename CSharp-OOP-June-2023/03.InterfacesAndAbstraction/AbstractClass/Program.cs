

Car car = new DieselCar();

abstract class Car
{
    public virtual void Start()
    {
        Console.WriteLine("Starting");
    }

    public abstract void Accelerate();

    public abstract int Speed { get; set; }
}

class DieselCar : Car
{
    public override int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Accelerate()
    {
        Console.WriteLine("Diesel acceleration is the best!");
    }
}