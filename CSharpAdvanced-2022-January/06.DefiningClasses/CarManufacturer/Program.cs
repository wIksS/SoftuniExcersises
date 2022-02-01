using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[]
            {
                new Tire(1995,1.6),
                new Tire(1995,1.6),
                new Tire(1995,1.9),
                new Tire(1995,1.9),
            };

            Engine engine = new Engine(555, 3);

            Car defaultCar = new Car("BMW","X3", 2006, 100000, 5000, engine, tires);

            for (int i = 0; i < defaultCar.Tires.Length; i++)
            {
                Console.WriteLine($"{defaultCar.Tires[i].Years} -> {defaultCar.Tires[i].Pressure}");
            }

            Console.WriteLine(defaultCar.WhoAmI());
            return;
            Car car = new Car();
            car.Model = "A5";
            car.Make = "Audi";
            car.Year = 1995;
            car.FuelQuantity = 100;
            car.FuelConsumption = 2;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Driving 30: ");
                car.Drive(30);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
