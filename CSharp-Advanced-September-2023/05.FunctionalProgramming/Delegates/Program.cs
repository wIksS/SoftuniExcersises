
using System.Text;

class Program
{
    public delegate int Filter(StringBuilder aaa, DateTime b, string format);

    static void Main()
    {
        Func<StringBuilder, DateTime, string, int> combine = Add;
        Filter combineDelegate = Add;

        Where(null, Add);
    }
    static int Add(StringBuilder a, DateTime b, string format)
    {
        Console.WriteLine(format);

        return 5;
    }
    static List<int>Where(List<int> list, Filter filter)
    {
        filter(new StringBuilder(), DateTime.Now, "");

        return null;
    }


}

