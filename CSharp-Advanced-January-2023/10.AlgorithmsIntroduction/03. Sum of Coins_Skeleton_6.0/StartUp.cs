namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            var coinsTaken = ChooseCoins(coins, sum);

            Console.WriteLine($"Number of coins to take: {coinsTaken.Values.Sum()}");

            foreach (var coin in coinsTaken)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {

            int sum = targetSum;

            coins = coins.OrderByDescending(x => x).ToArray();

            Dictionary<int, int> coinsTaken = new Dictionary<int, int>();
            int reachedSum = 0;
            int coinsCount = 0;
            while (reachedSum < sum)
            {
                bool coinTaken = false;
                for (int i = 0; i < coins.Count; i++)
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

            return coinsTaken;
        }
    }
}