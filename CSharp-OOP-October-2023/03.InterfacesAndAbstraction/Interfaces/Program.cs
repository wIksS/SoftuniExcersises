
using System.Collections;

IRenderer renderer = new ConsoleRenderer();

renderer.Write();

public interface IRenderer : IDisposable, IEnumerable<IRenderer>
{
    void Write();

    public ConsoleColor Color{ get; set; }
}

class Renderer
{
    public ConsoleColor Color { get; set; }
}

class ConsoleRenderer : Renderer, IRenderer
{

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IRenderer> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Write()
    {
        Console.WriteLine("Hello From ConsoleRenderer");
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}