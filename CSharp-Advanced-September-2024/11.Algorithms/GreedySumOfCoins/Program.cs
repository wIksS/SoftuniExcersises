
Dictionary<int, int> coinsTaken = new Dictionary<int, int>();
int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

coins = coins.OrderByDescending(x => x).ToArray();

int desiredChange = int.Parse(Console.ReadLine());

int currentChange = 0;

// take largest coin that doesn't go over desired change
int coinsTakenAmount = 0;

while (currentChange != desiredChange)
{
    bool isCoinTaken = false;
    for (int i = 0; i < coins.Length; i++)
    {
        if (currentChange + coins[i] <= desiredChange)
        {
            currentChange += coins[i];
            isCoinTaken = true;
            if (!coinsTaken.ContainsKey(coins[i]))
            {
                coinsTaken.Add(coins[i], 0);
            }

            coinsTaken[coins[i]]++;
            coinsTakenAmount++;
            break;
        }
    }

    if (!isCoinTaken)
    {
        break;
    }
}

if (desiredChange != currentChange)
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine($"Number of coins to take: {coinsTakenAmount}");

    foreach (var coinTaken in coinsTaken)
    {
        Console.WriteLine($"{coinTaken.Value} coin(s) with value {coinTaken.Key}");
    }
}

