



class PaperPrinter : IPritanble, IDisposable
{
    public void ChangeFormat(string format)
    {
    }

    public void Print()
    {

    }

    public void Dispose()
    {

    }
}

class ConsolePrinter<T> : IPritanble<T>
{
    public void Print(T el)
    {

    }

    public void ChangeFormat(string format)
    {

    }
}

interface IPritanble<T>
{
    public void Print(T element);

    public void ChangeFormat(string format);
}