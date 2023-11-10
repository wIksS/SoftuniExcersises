
Programmer csharp = new CSharpProgrammer();

csharp.Program();

Console.WriteLine(csharp);

class Programmer
{
    public virtual string Name
    {
        get
        {
            return "42";
        }
    }
    public virtual void Program()
    {
        Console.WriteLine("Programming");
    }
}

class CSharpProgrammer : Programmer
{
    public override string Name
    {
        get { return "43"; }
    }

    public override void Program()
    {
        base.Program();
        Console.WriteLine("Ne programit in c#");
    }

    public override string ToString()
    {
        return "CSharp Programmer. Cool";
    }
}