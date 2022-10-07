using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(245, 3000);
            Tire[] tires = new Tire[4]
            {
                new Tire(2022,5),
                new Tire(2022,5),
                new Tire(2022,5),
                new Tire(2022,5),
            };
            Car car = new Car("BMW", "X3", 2006,5,100, engine, tires);

            Console.WriteLine($"{car.Tires[0].Pressure}");

            while (true)
            {
                Console.WriteLine($"Where to go?");

                car.Drive(int.Parse(Console.ReadLine()));
                Console.WriteLine($"{car.WhoAmI()}");
            }

        }
    }
}
