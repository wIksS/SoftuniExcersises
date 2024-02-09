
using (Reader reader = new Reader())
{
    Console.WriteLine("Before dispose");
}


Console.WriteLine("After dispose");



class Reader : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Dispose is called!");
    }
}