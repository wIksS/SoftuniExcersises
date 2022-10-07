using System;
using System.Collections.Generic;

namespace _03.SetsAndDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bulgaria - 7mil
            SortedDictionary<string, int> countriesPopulation = new SortedDictionary<string, int>();

            countriesPopulation.Add("Bulgaria", 7);
            countriesPopulation.Add("Albania", 6);
            countriesPopulation.Add("America", 500);

            //countriesPopulation["Bulgaria"] = 8;
            //countriesPopulation.Add("Bulgaria", 8);

            Console.WriteLine($"Contains: Bulgaria : {countriesPopulation.ContainsKey("Bulgaria")}");
            Console.WriteLine($"Contains: Bul : {countriesPopulation.ContainsKey("Bul")}");

            Console.WriteLine($"ContainsValue: 500 : {countriesPopulation.ContainsValue(500)}");

            Console.WriteLine(string.Join(",", countriesPopulation));
        }
    }
}
