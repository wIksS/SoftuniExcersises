

List<int> list = new List<int>() { 1, 5, 3, 4, 17, -21, 23 };

//list.Sort();
List<int> sortedList = list.OrderBy(num => num).ToList();

Console.WriteLine($"Old List: {String.Join(",", list)}");
Console.WriteLine($"New List: {String.Join(",", sortedList)}");

List<DateTime> dates = new List<DateTime>
{
    DateTime.Now,
    DateTime.Now.AddDays(-365),
    DateTime.Now.AddDays(270),
    DateTime.Now.AddDays(35),
};

dates = dates.OrderBy(d => d.Day)
    .ThenBy(d=> d.Month).ToList();

Console.WriteLine($"{string.Join("\n",dates)}");