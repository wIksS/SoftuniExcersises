

Child child;

class Parent
{
    private int privateField;
    protected int protectedField;
    internal int internalField;
    public int publicField;
}

class Child : Parent
{
    public void PrintChild()
    {
        Console.WriteLine(base.publicField);
        Console.WriteLine(internalField);
        Console.WriteLine(protectedField);
    }
}