

int greenCount = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
int passedCount = 0;

string command = Console.ReadLine();

while (command != "end") 
{
    if (command == "green")
    {
        for (int i = 0; i < greenCount; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }

            string car = cars.Dequeue();

            Console.WriteLine($"{car} passed!");
            passedCount++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{passedCount} cars passed the crossroads.");