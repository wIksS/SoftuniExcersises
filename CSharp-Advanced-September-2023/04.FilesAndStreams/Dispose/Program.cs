
SoftUniStream stream = new SoftUniStream();
int[] arr = new int[2];

using (stream)
{
    Console.WriteLine("Inside using");
    stream.Read();
    Console.WriteLine(arr[5]);
}

Console.WriteLine("Outside using");



class SoftUniStream : IDisposable
{
    public void Read()
    {
        Console.WriteLine("Reading from stream");
    }
    public void Dispose()
    {
        Console.WriteLine("Dispose called!!!");
    }
}

//try
//{
//    Console.WriteLine("Inside using");

//}
//catch (Exception)
//{
//}
//finally
//{
//    stream.Dispose();
//}
