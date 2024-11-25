namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static int currentChange = 0;
        public static int coinsTakenAmount = 0;
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            coins = coins.OrderByDescending(x => x).ToArray();
            int targetSum = int.Parse(Console.ReadLine());
            var coinsTaken = ChooseCoins(coins, targetSum);

            if (targetSum != currentChange)
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

        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> coinsTaken = new Dictionary<int, int>();

            coins = coins.OrderByDescending(x => x).ToList();
            // take largest coin that doesn't go over desired change

            while (currentChange != targetSum)
            {
                bool isCoinTaken = false;
                for (int i = 0; i < coins.Count; i++)
                {
                    if (currentChange + coins[i] <= targetSum)
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

            return coinsTaken;
        }
    }
}