using System;
using System.Collections.Generic;

namespace NestedDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>()
            {
                { "BG",
                    new Dictionary<string,int>()
                    {
                        { "Sofia",2},
                        { "Plovdiv",2},
                        { "Varna",2},
                        { "Burgas",2},
                    }
                },
                { "UK", new Dictionary<string, int>(){
                        { "London",22},
                }
                }
            };


            countries["BG"]["Sofia"] += 10;

            foreach (var country in countries)
            {
                Console.WriteLine($"{country.Key} --> ");

                foreach (var city in country.Value)
                {
                    Console.WriteLine($"    {city.Key}:{city.Value}");
                }
            }
        }
    }
}
