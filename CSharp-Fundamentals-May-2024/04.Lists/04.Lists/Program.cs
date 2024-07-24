
int[] array = new int[5];


List<int> list = new List<int>();

Console.WriteLine($"Count -> {list.Count}");

list.Add(5);

Console.WriteLine(list[0]);

Console.WriteLine($"Count -> {list.Count}");

list.Add(4);
list.Add(3);
list.Add(2);

Console.WriteLine(list[1]);
Console.WriteLine(list[2]);
Console.WriteLine(list[3]);
Console.WriteLine(list[4]);

Console.WriteLine($"Count -> {list.Count}");
