
namespace SumOfCoins
{
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(c => c).ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            ChooseCoins(coins, targetSum);
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            //int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(c => c).ToArray();

            //int targetSum = int.Parse(Console.ReadLine());

            int currentSum = 0;

            Dictionary<int, int> usedCoins = new Dictionary<int, int>();
            int numberOfCoins = 0;
            while (true)
            {
                bool isCoinTaken = false;
                for (int i = 0; i < coins.Count; i++)
                {
                    if (currentSum + coins[i] <= targetSum)
                    {
                        if (!usedCoins.ContainsKey(coins[i]))
                        {
                            usedCoins.Add(coins[i], 0);
                        }

                        usedCoins[coins[i]]++;
                        currentSum += coins[i];
                        isCoinTaken = true;
                        numberOfCoins++;
                        break;
                    }
                }

                if (!isCoinTaken)
                {
                    break;
                }
            }

            if (currentSum != targetSum)
            {
                Console.WriteLine("Error");
                return null;
            }
            Console.WriteLine($"Number of coins to take: {numberOfCoins}");

            foreach (var coin in usedCoins)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }

            return usedCoins;
        }
    }
}

