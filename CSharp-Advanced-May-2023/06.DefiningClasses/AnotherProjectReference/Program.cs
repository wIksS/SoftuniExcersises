using CarManufacturer;

Engine engine = new Engine(265, 2);
Tire[] tires = new Tire[4]
{
                new Tire(2020, 2.2),
                new Tire(2020, 2.2),
                new Tire(2020, 2.4),
                new Tire(2020, 2.4),
};

Car car = new Car("BMW", "X3", 2006, 100, 2, engine, tires);

car.Drive(10);
car.Drive(50);

Console.WriteLine(car.WhoAmI());

Console.WriteLine(car.Engine.HorsePower);
Console.WriteLine(car.Tires[0].Pressure);