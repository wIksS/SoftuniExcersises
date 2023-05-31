

SortedDictionary<int, string> studentAges = new SortedDictionary<int, string>();

studentAges.Add(1, "1");
studentAges.Add(5, "5");
studentAges.Add(2, "2");
studentAges.Add(13, "13");
studentAges.Add(8, "8");
studentAges.Add(21, "21");


foreach (var item in studentAges)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

SortedDictionary<DateTime, string> events = new SortedDictionary<DateTime, string>();

DateTime t = DateTime.Now;
t.CompareTo(new DateTime());
events.Add(new DateTime(2022, 5, 18), "Top Eventa");
events.Add(new DateTime(2022, 5, 2), "Futbol");
events.Add(new DateTime(2022, 5, 5), "Tenis");
events.Add(new DateTime(2022, 5, 9), "Skuka");
events.Add(new DateTime(2022, 5, 23), "8");
events.Add(new DateTime(2022, 5, 17), "21");

foreach (var item in events)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

SortedDictionary<List<int>, int> unSortable;