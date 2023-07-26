using InterfaceInheritance;

InterfaceInheritance.DateTime date = new InterfaceInheritance.DateTime();

interface Readable
{
    string Read();
}

interface Writable : Readable
{
    void Write(string text);
}

class Printer :  Writable
{
    public string Read()
    {
        throw new NotImplementedException();
    }

    public void Write(string text)
    {
        throw new NotImplementedException();
    }
}