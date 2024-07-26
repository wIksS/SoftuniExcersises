

IRenderer console = new TextRenderer(); 

Dictionary<string, Car> cars = new Dictionary<string, Car>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] splittedInput = Console.ReadLine().Split("|");
    string carName = splittedInput[0];
    int mileage = int.Parse(splittedInput[1]);
    int fuel = int.Parse(splittedInput[2]);

    Car car = new Car()
    {
        Name = carName,
        Fuel = fuel,
        Mileage = mileage
    };

    cars.Add(carName, car);
}

string command = Console.ReadLine();

while (command != "Stop")
{
    string[] splittedInput = command.Split(" : ");
    //Drive : {car} : {distance} : {fuel}
    if (splittedInput[0] == "Drive")
    {
        string carName = splittedInput[1];
        int distance = int.Parse(splittedInput[2]);
        int fuel = int.Parse(splittedInput[3]);

        Car car = cars[carName];

        if (car.Fuel < fuel)
        {
            console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            car.Mileage += distance;
            car.Fuel -= fuel;

            console.WriteLine($"{car.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (car.Mileage >= 100_000)
            {
                console.WriteLine($"Time to sell the {car.Name}!");
                cars.Remove(car.Name);
            }
        }
    }

    if (splittedInput[0] == "Refuel")
    {
        string carName = splittedInput[1];
        int refuelAmount = int.Parse(splittedInput[2]);
        Car car = cars[carName];

        if (car.Fuel + refuelAmount > 75)
        {
            refuelAmount = 75 - car.Fuel;
        }

        car.Fuel += refuelAmount;

        console.WriteLine($"{car.Name} refueled with {refuelAmount} liters");
    }

    if (splittedInput[0] == "Revert")
    {
        string carName = splittedInput[1];
        int kilometers = int.Parse(splittedInput[2]);

        Car car = cars[carName];

        car.Mileage -= kilometers;

        if (car.Mileage > 10_000)
        {
            console.WriteLine($"{car.Name} mileage decreased by {kilometers} kilometers");
        }
        else
        {
            car.Mileage = 10_000;
        }
    }

    command = Console.ReadLine();
}


foreach (var (_, car) in cars)
{
    console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
}


class Car
{
    public string Name { get; set; }

    public int Mileage { get; set; }

    public int Fuel { get; set; }
}

public interface IRenderer
{
    void WriteLine(string message);
    void Write(string message);
}

internal class ConsoleRenderer : IRenderer
{
    public void Write(string message)
    {
        Console.Write(message);
    }

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}

public class TextRenderer : IRenderer
{
    string path = "../../../output.txt";

    public TextRenderer()
    {
        File.Delete(path);
    }

    public void Write(string message)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.Write(message);
        }
    }

    public void WriteLine(string message)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(message);
        }
    }
}