using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ExamPreparation
{
    class Location
    {
        public Location(int neededArea, int foundTiles)
        {
            NeededArea = neededArea;
            FoundTiles = foundTiles;
        }

        public int NeededArea { get; set; }

        public int FoundTiles { get; set; }
    }

    internal class Program
    {
        /*
30 6 10 10
10 20 5 6 30 35


        */
        static void Main(string[] args)
        {
            Stack<int> whites = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            Queue<int> greys = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                { "Sink", 40},
                { "Oven", 50},
                { "Countertop", 60},
                { "Wall", 70},
            };

            Dictionary<string, int> possibleLocations = new Dictionary<string, int>()
            {
                { "Sink", 0},
                { "Oven", 0},
                { "Countertop", 0},
                { "Wall", 0},
                { "Floor", 0},
            };

            while (whites.Count != 0 && greys.Count != 0)
            {
                //white = 9  grey = 9
                int white = whites.Pop();
                int grey = greys.Dequeue();

                if (white == grey)
                {
                    int newTile = white + grey;

                    KeyValuePair<string, int> possibleLocation = locations.FirstOrDefault(x => x.Value == newTile);

                    if (possibleLocation.Key != null)
                    {
                        possibleLocations[possibleLocation.Key]++;
                    }
                    else
                    {
                        possibleLocations["Floor"]++;
                    }
                }
                else
                {
                    whites.Push(white / 2);
                    greys.Enqueue(grey);
                }
            }

            string whitesLeft = whites.Count == 0 ? "none" : string.Join(", ", whites);
            string greysLeft = greys.Count == 0 ? "none" : string.Join(", ", greys);

            Console.WriteLine($"White tiles left: {whitesLeft}");
            Console.WriteLine($"Grey tiles left: {greysLeft}");

            possibleLocations = possibleLocations.Where(l => l.Value > 0).OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(l => l.Key, l => l.Value);

            foreach (var location in possibleLocations)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }

        }
    }
}
