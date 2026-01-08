int n = int.Parse(Console.ReadLine());

Queue<KeyValuePair<int,int>> pumps = new Queue<KeyValuePair<int, int>>();

for (int i = 0; i < n; i++)
{
    //5 10
    int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();

    pumps.Enqueue(new KeyValuePair<int, int>(pump[0], pump[1]));
}

//foreach (int[] pump in pumps)
//{
//    Console.WriteLine($"Pump: {pump[0]} Distance: {pump[1]}");
//}

int pumpPosition = 0;

while (pumps.Count > 0)
{
    int currentFuel = 0;
    bool isPathValid = true;
    foreach (var pump in pumps)
    {
        currentFuel += pump.Key;
        currentFuel -= pump.Value;
        if (currentFuel < 0)
        {
            pumps.Enqueue(pumps.Dequeue());
            pumpPosition++;
            isPathValid = false;

            break;
        }
    }

    if (isPathValid)
    {
        break;
    }
}

Console.WriteLine(pumpPosition);