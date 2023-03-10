
int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int sum = int.Parse(Console.ReadLine());

coins = coins.OrderByDescending(x => x).ToArray();

Dictionary<int,int> coinsTaken = new Dictionary<int,int>();
int reachedSum = 0;
int coinsCount = 0;
while (reachedSum < sum)
{
    bool coinTaken = false;
    for (int i = 0; i < coins.Length; i++)
    {
        if (coins[i] + reachedSum <= sum)
        {
            if (coinsTaken.ContainsKey(coins[i]) == false)
            {
                coinsTaken.Add(coins[i], 0);
            }

            coinsTaken[coins[i]]++;
            coinsCount++;
            reachedSum += coins[i];
            coinTaken = true;
            break;
        }
    }

    if (coinTaken == false)
        throw new InvalidOperationException();
}

Console.WriteLine($"Number of coins to take: {coinsCount}");

foreach (var coin in coinsTaken)
{
    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
}