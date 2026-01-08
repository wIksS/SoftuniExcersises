

int greenLightBaseSeconds = int.Parse(Console.ReadLine());
int windowBaseSeconds = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();
bool isCrash = false;
int passedCount = 0;
string command = Console.ReadLine().Trim();

while (command.ToLower() != "end")
{
    if (command.ToLower() == "green" && cars.Count > 0)
    {
        int greenLight = greenLightBaseSeconds;
        int window = windowBaseSeconds;
        string car = cars.Dequeue();
        passedCount++;
        Queue<char> carSymbols = new Queue<char>(car);

        while (greenLight-- > 0)
        {
            if (carSymbols.Count == 0)
            {
                if (cars.Count == 0)
                {
                    break;
                }

                car = cars.Dequeue();
                passedCount++;
                carSymbols = new Queue<char>(car);
            }

            carSymbols.Dequeue();
        }

        if (carSymbols.Count > 0)
        {
            while (window-- > 0 && carSymbols.Count > 0)
            {
                carSymbols.Dequeue();
            }

            if (carSymbols.Count > 0)
            {
                isCrash = true;
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{car} was hit at {carSymbols.Dequeue()}.");
                break;
            }
        }
    }
    else if (command.ToLower() != "green")
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine().Trim();
}

if (!isCrash)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{passedCount} total cars passed the crossroads.");
}