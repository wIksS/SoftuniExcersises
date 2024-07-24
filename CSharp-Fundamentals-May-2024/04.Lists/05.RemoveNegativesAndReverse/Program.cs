

List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0)
    {
        list.RemoveAt(i--);
        //list.Remove(list[i]);
    }
}

list.Reverse();

if (list.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", list));
}