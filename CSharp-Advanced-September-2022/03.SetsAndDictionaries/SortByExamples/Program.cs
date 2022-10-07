using System;
using System.Collections.Generic;
using System.Linq;

namespace SortByExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countriesPopulation = new Dictionary<string, int>()
            {
                { "Italy", 7},
                { "Bul", 7},
                { "Alb", 7},
                { "USA", 500},
            };

            long number = 5;
            int number2 = (int)number;


            Dictionary<string,int> sortedDict = countriesPopulation
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x=>x.Key, x=>x.Value);

            Console.WriteLine(String.Join(", ", countriesPopulation));
        }
    }
}
