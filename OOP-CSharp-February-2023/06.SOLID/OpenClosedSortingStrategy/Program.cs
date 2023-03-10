

using OpenClosedSortingStrategy;

string strategy = Console.ReadLine();

Sorter sorter = new Sorter(strategy);

sorter.Sort(new List<int>() { 1, 2, 3 });