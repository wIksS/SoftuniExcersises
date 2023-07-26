
IFlyable flyable = new Plane();

IDrivable drivable = new Plane();

flyable.Break();
drivable.Break();

interface IDrivable
{
    void Break();
}

interface IFlyable
{
    void Break();
}

class Plane : IDrivable, IFlyable
{
    void IDrivable.Break()
    {
        Console.WriteLine("Drivable Break");
    }

    void IFlyable.Break()
    {
        Console.WriteLine("Flyable Break");
    }
}