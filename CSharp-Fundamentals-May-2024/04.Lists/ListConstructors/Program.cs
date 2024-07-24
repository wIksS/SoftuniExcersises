

List<int> list = new List<int>();

Console.WriteLine(list.Count);

int i = 0;
while (true)
{
    if (list.Count % 100000000 == 0)
    {
        Console.WriteLine(list.Count);
    }

    list.Add(i++);
}