

IClosable fileReader = new SoftuniFileReader();

fileReader.Close();


public interface IClosable
{
    void Close();

    int Clean();
}

class SoftuniFileReader : IClosable
{
    public void Close()
    {
        Console.WriteLine("Softuni reader closed");
    }

    public int Clean()
    {
        return 5;
    }
}

class SoftuniWebReader : SoftuniFileReader, IClosable, IDisposable
{
    public void Close()
    {
        Console.WriteLine("Softuni web reader");
    }

    public int Clean()
    {
        return 6;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}