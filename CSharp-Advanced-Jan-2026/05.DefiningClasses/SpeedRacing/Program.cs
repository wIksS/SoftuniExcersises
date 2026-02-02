namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split();

                string carModel = input[1];
                double distance = double.Parse(input[2]);

                Car car = cars.First(c => c.Model == carModel);
                car.Drive(distance);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
