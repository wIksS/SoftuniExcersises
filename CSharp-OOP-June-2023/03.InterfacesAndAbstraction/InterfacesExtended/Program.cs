IDrivable car = new Car();

PrintCar(car);

void PrintCar(IDrivable drivable)
{
    drivable.Start();
    Console.WriteLine(drivable.ToString());
}

interface IDrivable
{
    void Start();

    void Break();
}

class Car : IDrivable
{
    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {

    }

    public int Speed { get; set; }
}
