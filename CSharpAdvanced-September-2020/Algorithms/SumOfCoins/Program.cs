using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 1, 4, 5, 10 };
            List<int> coinsReturned = new List<int>();
            int n = int.Parse(Console.ReadLine());

            int change = 0;
            coins = coins.OrderByDescending(c => c).ToArray();
            while (change < n)
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    if (change + coins[i] <= n)
                    {
                        change += coins[i];
                        coinsReturned.Add(coins[i]);
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(",",coinsReturned));
        }
    }
}
