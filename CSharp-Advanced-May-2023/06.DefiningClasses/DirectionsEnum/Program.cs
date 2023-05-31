
using DirectionsEnum;

Console.WriteLine((int)Direction.down);
Console.WriteLine((Direction)43);

Direction dir = (Direction)55;

Console.WriteLine(dir);

foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
{
    Console.WriteLine(item);
}

List<int> list = new List<int>()
{
    1,2,3,4,
};