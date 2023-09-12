

int n = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int passedCarsCount = 0;

string command = Console.ReadLine();    

while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            passedCarsCount++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");