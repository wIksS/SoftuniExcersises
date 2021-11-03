using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> countryTowns = new Dictionary<string, List<string>>();

            countryTowns.Add("Bulgaria", new List<string>());
            countryTowns.Add("Croatia", new List<string>());
            countryTowns.Add("USA", new List<string>());
            countryTowns.Add("AA", new List<string>());

            countryTowns["Bulgaria"].Add("Sofia");
            countryTowns["Bulgaria"].Add("Plovdiv");
            countryTowns["Bulgaria"].Add("Varna");

            countryTowns["USA"].Add("Los Angeles");
            countryTowns["USA"].Add("New York");
            countryTowns["USA"].Add("Santa Monica");

            countryTowns = countryTowns
                .OrderBy(c => c.Value.Count)
                .ThenBy(c => c.Key)
                .ToDictionary(c => c.Key, c=> c.Value);

            foreach (var country in countryTowns)
            {
                Console.WriteLine($"{country.Key} => {string.Join(" ", country.Value)}");
            }

        }
    }
}
