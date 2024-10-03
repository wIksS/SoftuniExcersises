
namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            //Car car = new Car()
            //{
            //    Make = "BMW",
            //    Model = "3",
            //    Year = 1997,
            //    FuelQuantity = 1000,
            //    FuelConsumption = 10
            //};

            //car.Drive(55);

            //Console.WriteLine(car.WhoAmI());

            //car.Drive(55);

            Car defaultCar = new Car();
            Console.WriteLine(defaultCar.WhoAmI());

            Car car = new Car("BMW", "3", 1997);
            Console.WriteLine(car.WhoAmI());

            Car fullCar = new Car("BMW", "3", 1997,60, 25);
            Console.WriteLine(fullCar.WhoAmI());

            Tire[] tires = new Tire[2]
            {
                new Tire(2000, 2),
                new Tire(2000,3)
            };

            Engine engine = new Engine(225, 3000);

            Car enginedCar = new Car("BMW", "3", 1997, 60, 25, engine, tires);


        }
    }
}