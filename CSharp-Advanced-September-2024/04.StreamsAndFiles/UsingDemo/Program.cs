

FileReader reader = new FileReader();
string s = null;
try
{
    Console.WriteLine(s[0]);
}
finally
{
    reader.Dispose();
}

Console.WriteLine("after closure");


class FileReader : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("I was closed! :(");
    }
}