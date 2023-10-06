namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            Car car3 = new Car();

            Car car2 = new Car("BMW", "X3", 2006);

            Car car = new Car("BMW","X3", 2006, 500, 300);

            car.Drive(5);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
