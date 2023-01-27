namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Engine threeLitreDiesel = new Engine(215, 3);
            Tire[] tires = new Tire[4]
            {
                new Tire(2020,200),
                new Tire(2020,200),
                new Tire(2020,200),
                new Tire(2020,200),
            };

            Car car = new Car("BMW","X3", 2006, 60, 10, threeLitreDiesel, tires);
            car.FuelQuantity = 100;
            car.FuelConsumption = 2;

            car.Drive(10);
            car.Drive(1000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
