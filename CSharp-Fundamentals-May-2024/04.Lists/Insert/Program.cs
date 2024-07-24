

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

list.Insert(2, 33);

Console.WriteLine(String.Join(",", list));

list.Insert(list.Count - 1, 100);
list.Add(101);


if (list.Contains(100))
{
    Console.WriteLine("Yay we have 100");
}