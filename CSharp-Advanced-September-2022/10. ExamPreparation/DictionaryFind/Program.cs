using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                { "Sink", 40},
                { "Oven", 50},
                { "Countertop", 60},
                { "Wall", 70},
            };

            int newTile = 122222;

            KeyValuePair<string,int> loc = locations.FirstOrDefault(l=>l.Value == newTile);

            if (loc.Key != null)
            {
                Console.WriteLine($"{loc.Key}: {loc.Value}");
            }
        }
    }
}
