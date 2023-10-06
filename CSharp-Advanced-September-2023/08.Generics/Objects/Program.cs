List<object> objects = new List<object>();

int test = int.Parse(Console.ReadLine());

//objects.Add(5l);
objects.Add("Hello");
objects.Add(DateTime.Now);
objects.Add(DateTime.Now);
objects.Add(DateTime.Now);
objects.Add(DateTime.Now);

foreach (var item in objects)
{
    if (item is DateTime)
    {
        Console.WriteLine($"{ ((DateTime)item).DayOfWeek}");

    }
}

List<int> safe= new List<int>();

safe.Add(5);
safe.Add("5");

List<object> list = new List<object>();

list.Add("Hello");
list.Add(5);