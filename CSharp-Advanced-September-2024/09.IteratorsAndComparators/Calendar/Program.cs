using System.Collections;

Calendar calendar = new Calendar();


foreach (var day in calendar)
{
    Console.WriteLine(day);
}

class Calendar : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new CalendarEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class CalendarEnumerator : IEnumerator<string>
{
   // private string[] days = new string[] { "Monday", "Tueday", "Wednesday" };
    private int index = 0;

    public string Current
    {
        get
        {
            return index.ToString();
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        index++;
        return index < 366;
    }

    public void Reset()
    {
        index = -1;
    }
}
