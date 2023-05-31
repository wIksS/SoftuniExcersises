Car car = new Car();

car.Engine = new Engine();

car.Engine.HorsePower = 200;

Console.WriteLine(car.Engine.HorsePower);



class Car
{
    public Engine Engine { get; set; }
}

class Engine
{
    public int HorsePower { get; set; }
}