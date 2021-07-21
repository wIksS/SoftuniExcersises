using System;
using System.Collections.Generic;

namespace DictionaryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> pair = new KeyValuePair<string, int>("key", 55);

            Console.WriteLine(pair.Key);
            Console.WriteLine(pair.Value);

            SortedDictionary<string, int> humanWeights = new SortedDictionary<string, int>();

            humanWeights.Add("Goshko", 130);
            humanWeights.Add("Bebi", 130);
            humanWeights.Add("Abi", 130);
            if (!humanWeights.ContainsKey("Goshko"))
            {
                humanWeights.Add("Goshko", 23);
            }
            else
            {
                humanWeights["Goshko"] = 23;
            }

            humanWeights["Pepi"] = 28;
            humanWeights["Pepi"] = 29;

            //humanWeights.Remove("Goshko");

            foreach (var item in humanWeights)
            {
                //humanWeights["Test"] = 5;
                Console.WriteLine($"Person: {item.Key} \nWeight: {humanWeights[item.Key]}");
            }
        }
    }
}
