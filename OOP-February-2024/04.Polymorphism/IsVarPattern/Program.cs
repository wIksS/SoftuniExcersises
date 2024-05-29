
List<List<int>> manyLists = new List<List<int>>();

manyLists.Where(list => list.Sum() is var sum && sum > 10 && sum < 20);

