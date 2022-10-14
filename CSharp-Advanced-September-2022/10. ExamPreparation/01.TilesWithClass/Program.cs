using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ExamPreparation
{
    class Location
    {
        public Location(string title, int neededArea)
        {
            NeededArea = neededArea;
            FoundTiles = 0;
            Title = title;
        }

        public int NeededArea { get; set; }

        public int FoundTiles { get; set; }
        public string Title { get; set; }
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

            List<Location> locations = new List<Location>()
            {
                new Location( "Sink", 40),
                new Location( "Oven", 50),
                new Location( "Countertop", 60),
                new Location( "Wall", 70),
                new Location( "Floor", -1),
            };

            Location floor = locations[4];

            while (whites.Count != 0 && greys.Count != 0)
            {
                //white = 9  grey = 9
                int white = whites.Pop();
                int grey = greys.Dequeue();

                if (white == grey)
                {
                    int newTile = white + grey;

                    Location possibleLocation = locations.FirstOrDefault(x => x.NeededArea == newTile);

                    if (possibleLocation != null)
                    {
                        possibleLocation.FoundTiles++;
                    }
                    else
                    {
                        floor.FoundTiles++;
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

            locations = locations.Where(l => l.FoundTiles > 0).OrderByDescending(x => x.FoundTiles)
                .ThenBy(x => x.Title).ToList();

            foreach (var location in locations)
            {
                Console.WriteLine($"{location.Title}: {location.FoundTiles}");
            }

        }
    }
}
