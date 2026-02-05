
//1, 2, 3, 4, 5, 6, 7, 8
using Froggy;

List<int> input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

Lake lake = new Lake(input);
bool isFirst = true;
foreach (int stone in lake)
{
    if (isFirst)
    {
        isFirst = false;
        Console.Write($"{stone}");
    }
    else
    {
        Console.Write($", {stone}");
    }
}
