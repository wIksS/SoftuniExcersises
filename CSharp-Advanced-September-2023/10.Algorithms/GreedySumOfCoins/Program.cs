

List<int> coins = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

coins = coins.OrderByDescending(x => x).ToList();
int sum = int.Parse(Console.ReadLine());

//5 3 2 1
//18
int currentSum = 0;
Dictionary<int, int> takenCoins = new Dictionary<int, int>();
int takenCoinsCount = 0;
while (currentSum != sum)
{
    bool coinTaken = false;
    for (int i = 0; i < coins.Count; i++)
    {
        if (currentSum + coins[i] <= sum)
        {
            if (!takenCoins.ContainsKey(coins[i]))
            {
                takenCoins.Add(coins[i], 0);
            }

            takenCoinsCount++;
            takenCoins[coins[i]]++;
            currentSum += coins[i];
            coinTaken = true;
            break;
        }
    }

    if (!coinTaken)
    {
        throw new InvalidOperationException();
    }
}

Console.WriteLine($"Number of coins to take: {takenCoinsCount}");
foreach (var item in takenCoins)
{
    Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
}