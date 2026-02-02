using System.Drawing;

namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);
                int? displacement = null;
                string efficiency = null;
                if (input.Length == 3)
                {
                    int parsed;
                    if (int.TryParse(input[2], out parsed))
                    {
                        displacement = parsed;
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }
                if (input.Length == 4)
                {
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];
                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            int m = int.Parse(Console.ReadLine());


            for (int i = 0; i < m; i++)
            {
                //"{model} {engine} {weight} {color}".
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engineModel= input[1];
                int? weight = null;
                string color = null;
                if (input.Length == 3)
                {
                    int parsedWeight;
                    if (int.TryParse(input[2], out parsedWeight))
                    {
                        weight = parsedWeight;
                    }
                    else
                    {
                        color = input[2];
                    }
                }
                if (input.Length == 4)
                {
                    weight = int.Parse(input[2]);
                    color = input[3];
                }

                Engine engine = engines.First(e => e.Model == engineModel);
                Car car = new Car(model, engine, weight, color);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
