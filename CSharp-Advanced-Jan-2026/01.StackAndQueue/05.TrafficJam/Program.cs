string upper = "FdFdDD";

Console.WriteLine(upper.ToLower());
Console.WriteLine(upper);



int n = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

string command = Console.ReadLine();
int passedCars = 0;

while (command.ToLower() != "end")
{
    if (command.ToLower() == "green")
    {
        int count = Math.Min(n, cars.Count);
        for (int i = 0; i < count; i++)
        {
            string car = cars.Dequeue();
            Console.WriteLine($"{car} passed!");
            passedCars++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{passedCars} cars passed the crossroads.");