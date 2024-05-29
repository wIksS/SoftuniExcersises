

Reader reader = new Reader();

reader.Dispose();

public class Reader: System.IDisposable, ExplicitInterfaceImplementation.IDisposable
{
    void System.IDisposable.Dispose()
    {
        Console.WriteLine("System disposable");
    }

    void ExplicitInterfaceImplementation.IDisposable.Dispose()
    {
        Console.WriteLine("ExplicitInterfaceImplementation disposable");
    }

    public void Dispose()
    {

    }
}